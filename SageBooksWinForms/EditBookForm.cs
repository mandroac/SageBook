using Domain.Models;
using System.ComponentModel;

namespace SageBooksWinForms
{
    public partial class EditBookForm : Form
    {
        private readonly Book _book;
        private readonly IEnumerable<Sage> _sages;

        public EditBookForm(Book book, IEnumerable<Sage> sages)
        {
            _book = book;
            _sages = sages;
            InitializeComponent();
        }

        public event EventHandler<Book> BookUpdatedEvent;
        public event EventHandler<Book> BookDeletedEvent;

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            bookNameTextBox.Text = _book.Name;
            bookDescriptionRichTextBox.Text = _book.Description;
            bookSagesComboBox.DataSource = new BindingList<Sage>(_sages.ToArray());

            // TODO: update this
            bookSagesComboBox.SelectedValue = _sages.FirstOrDefault(s => s.Id == _book.Sages.FirstOrDefault()?.Id);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            _book.Name = bookNameTextBox.Text;
            _book.Description = bookDescriptionRichTextBox.Text;

            BookUpdatedEvent?.Invoke(this, _book);
            Close();

        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            BookDeletedEvent?.Invoke(this, _book);
            Close();
        }
    }
}
