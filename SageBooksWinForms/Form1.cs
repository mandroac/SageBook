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

        private void ClearBooksSelection()
        {
            booksDataGrid.ClearSelection();
            deleteBookButton.Enabled = false;
            editBookButton.Enabled = false;
        }

        private void ClearSagesSelection()
        {
            sagesDataGrid.ClearSelection();
            deleteSageButton.Enabled = false;
            editSageButton.Enabled = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var sages = _dbContext.Sages.Include(s => s.Books).ToList();
            var books = _dbContext.Books.Include(b => b.Sages).ToList();
            sageBindingSource.DataSource = new BindingList<Sage>(sages);
            bookBindingSource.DataSource = new BindingList<Book>(books);
        }

        private void booksDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && (e.Value is IEnumerable<Sage> sagesList))
            {
                e.Value = string.Join(", ", sagesList.Select(sl => sl.Name));
            }
        }

        private void sagesDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && (e.Value is IEnumerable<Book> booksList))
            {
                e.Value = string.Join(", ", booksList.Select(bl => bl.Name));
            }
        }

        private void booksDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editBookButton.Enabled = booksDataGrid.SelectedRows.Count > 0;
            deleteBookButton.Enabled = booksDataGrid.SelectedRows.Count > 0;
        }

        private void sagesDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            editSageButton.Enabled = sagesDataGrid.SelectedRows.Count > 0;
            deleteSageButton.Enabled = sagesDataGrid.SelectedRows.Count > 0;
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

        private void bookEditForm_BookCreated(object sender, Book book)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();

            (bookBindingSource.DataSource as BindingList<Book>)!.Add(book);
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

        private void sageEditForm_SageCreated(object sender, Sage sage)
        {
            _dbContext.Sages.Add(sage);
            _dbContext.SaveChanges();

            (sageBindingSource.DataSource as BindingList<Sage>)!.Add(sage);
        }

        private void createSageButton_Click(object sender, EventArgs e)
        {
            var sageEditForm = new EditSageForm(new Sage(), bookBindingSource.DataSource as IEnumerable<Book>, false);
            sageEditForm.ModelCreatedEvent += sageEditForm_SageCreated;
            sageEditForm.ShowDialog(this);
        }

        private void createBookButton_Click(object sender, EventArgs e)
        {
            var bookEditForm = new EditBookForm(new Book(), sageBindingSource.DataSource as IEnumerable<Sage>, false);
            bookEditForm.ModelCreatedEvent += bookEditForm_BookCreated;
            bookEditForm.ShowDialog(this);
        }

        private void editBookButton_Click(object sender, EventArgs e)
        {
            var book = (bookBindingSource.DataSource as BindingList<Book>)[booksDataGrid.SelectedRows[0].Index];

            var bookEditForm = new EditBookForm(book, sageBindingSource.DataSource as IEnumerable<Sage>);
            bookEditForm.ModelUpdatedEvent += bookEditForm_BookUpdated;
            bookEditForm.ModelDeletedEvent += bookEditForm_BookDeleted;
            bookEditForm.ShowDialog(this);

            ClearBooksSelection();
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            var booksBindingList = bookBindingSource.DataSource as BindingList<Book>;
            var book = booksBindingList[booksDataGrid.SelectedRows[0].Index];

            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();

            booksBindingList.Remove(book);
            ClearBooksSelection();
        }

        private void deleteSageButton_Click(object sender, EventArgs e)
        {
            var sagesBindingList = sageBindingSource.DataSource as BindingList<Sage>;
            var sage = sagesBindingList[sagesDataGrid.SelectedRows[0].Index];

            _dbContext.Sages.Remove(sage);
            _dbContext.SaveChanges();

            sagesBindingList.Remove(sage);

            ClearSagesSelection();
        }

        private void editSageButton_Click(object sender, EventArgs e)
        {
            var sage = (sageBindingSource.DataSource as BindingList<Sage>)[sagesDataGrid.SelectedRows[0].Index];

            var sageEditForm = new EditSageForm(sage, bookBindingSource.DataSource as IEnumerable<Book>);
            sageEditForm.ModelUpdatedEvent += sageEditForm_SageUpdated;
            sageEditForm.ModelDeletedEvent += sageEditForm_SageDeleted;
            sageEditForm.ShowDialog(this);

            ClearSagesSelection();
        }
    }
}