using Domain.Models;

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

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            bookNameTextBox.Text = _book.Name;
            bookDescriptionRichTextBox.Text = _book.Description;
            bookSagesComboBox.Items.AddRange(_sages.ToArray()); // cant do that
            bookSagesComboBox.SelectedValue = _sages.FirstOrDefault(s => s.Id == _book.Sages.FirstOrDefault()?.Id);
        }
    }
}
