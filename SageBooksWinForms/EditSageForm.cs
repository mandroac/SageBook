using Domain.Models;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace SageBooksWinForms
{
    public partial class EditSageForm : Form
    {
        private readonly Sage _sage;
        private readonly IEnumerable<Book> _books;

        public EditSageForm(Sage sage, IEnumerable<Book> books)
        {
            _sage = sage;
            _books = books;
            InitializeComponent();
        }

        public event EventHandler<Sage> SageUpdatedEvent;
        public event EventHandler<Sage> SageDeletedEvent;

        private void EditSageForm_Load(object sender, EventArgs e)
        {
            if (_sage.Photo is not null)
            {
                using var ms = new MemoryStream(_sage.Photo);
                sagePhotoPictureBox.Image = new Bitmap(ms);
            }
            else sagePhotoPictureBox.Image = sagePhotoPictureBox.ErrorImage;

            sageNameTextBox.Text = _sage.Name;
            sageAgeNumericUpDown.Value = _sage.Age;
            sageCityListBox.Text = _sage.City;
            sageBooksComboBox.DataSource = new BindingList<Book>(_books.ToArray());
        }

        private void sagePhotoButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                selectedSagePhotoLabel.Text = openFileDialog1.FileName;

                if (!string.IsNullOrEmpty(openFileDialog1.FileName))
                {
                    using var ms = new MemoryStream();
                    openFileDialog1.OpenFile().CopyTo(ms);
                    ms.Seek(0, SeekOrigin.Begin);

                    sagePhotoPictureBox.Image = new Bitmap(ms);
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteSageButton_Click(object sender, EventArgs e)
        {
            SageDeletedEvent?.Invoke(this, _sage);
            Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            _sage.Name = sageNameTextBox.Text;
            _sage.Age = (int)sageAgeNumericUpDown.Value;
            _sage.City = sageCityListBox.Text;

            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                using var ms = new MemoryStream();
                sagePhotoPictureBox.Image.Save(ms, ImageFormat.Png);
                _sage.Photo = ms.ToArray();
            }

            SageUpdatedEvent?.Invoke(this, _sage);
            Close();
        }
    }
}
