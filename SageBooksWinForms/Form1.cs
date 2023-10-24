using DataAccess;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace SageBooksWinForms
{
    public partial class Form1 : Form
    {
        private protected SageBookDbContext _dbContext;
        public Form1()
        {
            _dbContext = new SageBookDbContext();
            InitializeComponent();
        }

        private void HandleControlValidation(bool isValid, string errorMessage,
            Control control, CancelEventArgs cancelEvent, ErrorProvider errorProvider)
        {
            if (!isValid)
            {
                cancelEvent.Cancel = true;
                sagesErrorProvider.SetError(control, errorMessage);
            }
            else
            {
                cancelEvent.Cancel = false;
                sagesErrorProvider.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var sages = _dbContext.Sages.Include(s => s.Books).ToList();
            var books = _dbContext.Books.Include(b => b.Sages).ToList();
            sageBindingSource.DataSource = new BindingList<Sage>(sages);
            bookBindingSource.DataSource = new BindingList<Book>(books);
        }

        private void saveBookButton_Click(object sender, EventArgs e)
        {
            if (booksErrorProvider.HasErrors) return;

            var newBook = new Book
            {
                Name = bookNameTextBox.Text,
                Description = bookDescriptionRichTextBox.Text,
                Sages = new List<Sage>(new[] { (Sage)bookSagesComboBox.SelectedItem })
            };
            _dbContext.Books.Add(newBook);
            _dbContext.SaveChanges();

            (bookBindingSource.DataSource as BindingList<Book>)!.Add(newBook);
        }

        private void saveSageButton_Click(object sender, EventArgs e)
        {
            if (sagesErrorProvider.HasErrors) return;

            var newSage = new Sage
            {
                Age = (int)sageAgeNumericUpDown.Value,
                Name = sageNameTextBox.Text,
                City = sageCityListBox.SelectedItem?.ToString(),
                Books = new List<Book>(new[] { (Book)sageBooksComboBox.SelectedItem }),
            };

            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                using var memoryStream = new MemoryStream();
                openFileDialog1.OpenFile().CopyTo(memoryStream);
                memoryStream.Seek(0, SeekOrigin.Begin);

                newSage.Photo = memoryStream.ToArray();
            }

            _dbContext.Sages.Add(newSage);
            _dbContext.SaveChanges();

            (sageBindingSource.DataSource as BindingList<Sage>)!.Add(newSage);
        }

        private void booksDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = "Details";
            }
            if (e.ColumnIndex == 3 && (e.Value is IEnumerable<Sage> sagesList))
            {
                e.Value = string.Join(", ", sagesList.Select(sl => sl.Name));
            }
        }

        private void sagesDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = "Details";
            }
            if (e.ColumnIndex == 5 && (e.Value is IEnumerable<Book> booksList))
            {
                e.Value = string.Join(", ", booksList.Select(bl => bl.Name));
            }
        }

        private void sageNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                HandleControlValidation(
                    !string.IsNullOrEmpty(textBox.Text),
                    "Sage name cannot be empty",
                    textBox, e, sagesErrorProvider);
            }
        }

        private void sageAgeNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (sender is NumericUpDown numericUpDown)
            {
                HandleControlValidation(
                    numericUpDown.Value > 1,
                    "Please specify a valid age",
                    numericUpDown, e, sagesErrorProvider);
            }
        }

        private void sageCityListBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is ComboBox comboBox)
            {
                HandleControlValidation(
                    comboBox.SelectedItem != null,
                    "Please select a city",
                    comboBox, e, sagesErrorProvider);
            }
        }

        private void bookNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                HandleControlValidation(
                    !string.IsNullOrEmpty(textBox.Text),
                    "Book name cannot be empty",
                    textBox, e, booksErrorProvider);
            }
        }

        private void bookDescriptionRichTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (sender is RichTextBox richTextBox)
            {
                HandleControlValidation(
                    !string.IsNullOrEmpty(richTextBox.Text),
                    "Book name cannot be empty",
                    richTextBox, e, booksErrorProvider);
            }
        }

        private void sagePhotoButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                selectedSagePhotoLabel.Text = openFileDialog1.FileName;
            }
        }

        private void booksDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && bookBindingSource.DataSource is BindingList<Book> books)
            {
                var book = books[e.RowIndex];
                var bookEditForm = new EditBookForm(book, sageBindingSource.DataSource as IEnumerable<Sage>);
                bookEditForm.BookUpdatedEvent += bookEditForm_BookUpdated;
                bookEditForm.BookDeletedEvent += bookEditForm_BookDeleted;
                bookEditForm.ShowDialog(this);
            }
        }

        private void bookEditForm_BookUpdated(object sender, Book book)
        {
            _dbContext.Update(book);
            _dbContext.SaveChanges();

            var booksBindingList = bookBindingSource.DataSource as BindingList<Book>;
            var initialBook = booksBindingList.SingleOrDefault(b => b.Id == book.Id);
            initialBook = book;

            booksBindingList.ResetBindings();
        }

        private void bookEditForm_BookDeleted(object sender, Book book)
        {
            _dbContext.Remove(book);
            _dbContext.SaveChanges();

            (bookBindingSource.DataSource as BindingList<Book>).Remove(book);
        }

        private void sagesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && sageBindingSource.DataSource is BindingList<Sage> sages)
            {
                var sage = sages[e.RowIndex];
                var sageEditForm = new EditSageForm(sage, bookBindingSource.DataSource as IEnumerable<Book>);
                sageEditForm.SageUpdatedEvent += sageEditForm_SageUpdated;
                sageEditForm.SageDeletedEvent += sageEditForm_SageDeleted;
                sageEditForm.ShowDialog(this);
            }
        }

        private void sageEditForm_SageUpdated(object sender, Sage sage)
        {
            _dbContext.Update(sage);
            _dbContext.SaveChanges();

            var sagesBindingList = sageBindingSource.DataSource as BindingList<Sage>;
            var initialSage = sagesBindingList.SingleOrDefault(s => s.Id == sage.Id);
            initialSage = sage;

            sagesBindingList.ResetBindings();
        }

        private void sageEditForm_SageDeleted(object sender, Sage sage)
        {
            _dbContext.Remove(sage);
            _dbContext.SaveChanges();

            (sageBindingSource.DataSource as BindingList<Sage>).Remove(sage);
        }
    }
}