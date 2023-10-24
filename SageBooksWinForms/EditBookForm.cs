using Domain.Models;
using System.ComponentModel;

namespace SageBooksWinForms
{
    public partial class EditBookForm : Form, IEditModelForm<Book>
    {
        private readonly Book _book;
        private readonly IEnumerable<Sage> _sages;

        public bool IsEditMode { get; set; }

        public event EventHandler<Book> ModelUpdatedEvent;
        public event EventHandler<Book> ModelDeletedEvent;
        public event EventHandler<Book> ModelCreatedEvent;

        public EditBookForm(Book book, IEnumerable<Sage> sages, bool isEditMode = true)
        {
            _book = book;
            _sages = sages;
            IsEditMode = isEditMode;
            InitializeComponent();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                Text = "Edit Book";
                deleteBookButton.Show();
            }
            else
            {
                Text = "Create Book";
                deleteBookButton.Hide();
            }

            bookNameTextBox.Text = _book.Name;
            bookDescriptionRichTextBox.Text = _book.Description;
            bookSagesCheckedListBox.DataSource = new BindingList<Sage>(_sages.ToArray());

            _book.Sages?.ToList().ForEach(sage =>
            {
                for (int i = 0; i < _sages.Count(); ++i)
                {
                    if (_sages.ElementAt(i).Id == sage.Id)
                    {
                        bookSagesCheckedListBox.SetItemChecked(i, true);
                        break;
                    }
                }
            });
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            _book.Name = bookNameTextBox.Text;
            _book.Description = bookDescriptionRichTextBox.Text;
            _book.Sages = bookSagesCheckedListBox.CheckedItems.Cast<Sage>().ToList();

            if (IsEditMode)
            {
                ModelUpdatedEvent?.Invoke(this, _book);
            }
            else
            {
                ModelCreatedEvent?.Invoke(this, _book);
            }

            Close();
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            ModelDeletedEvent?.Invoke(this, _book);
            Close();
        }
    }
}
