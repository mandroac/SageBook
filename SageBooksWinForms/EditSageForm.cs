using Domain.Models;
using System.ComponentModel;
using System.Drawing.Imaging;

namespace SageBooksWinForms
{
    public partial class EditSageForm : Form, IEditModelForm<Sage>
    {
        private readonly Sage _sage;
        private readonly IEnumerable<Book> _books;

        public event EventHandler<Sage> ModelUpdatedEvent;
        public event EventHandler<Sage> ModelDeletedEvent;
        public event EventHandler<Sage> ModelCreatedEvent;

        public bool IsEditMode { get; set; }

        public EditSageForm(Sage sage, IEnumerable<Book> books, bool isEditMode = true)
        {
            _sage = sage;
            _books = books;
            IsEditMode = isEditMode;
            InitializeComponent();
        }

        private void EditSageForm_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                Text = "Edit Sage";
                deleteSageButton.Show();
            }
            else
            {
                Text = "Create Sage";
                deleteSageButton.Hide();
            }

            if (_sage.Photo is not null)
            {
                using var ms = new MemoryStream(_sage.Photo);
                sagePhotoPictureBox.Image = new Bitmap(ms);
            }
            else sagePhotoPictureBox.Image = sagePhotoPictureBox.ErrorImage;

            sageNameTextBox.Text = _sage.Name;
            sageAgeNumericUpDown.Value = _sage.Age;
            sageCityListBox.Text = _sage.City;

            sageBooksCheckedListBox.DataSource = new BindingList<Book>(_books.ToArray());

            _sage.Books?.ToList().ForEach(book =>
            {
                for (int i = 0; i < _books.Count(); ++i)
                {
                    if (_books.ElementAt(i).Id == book.Id)
                    {
                        sageBooksCheckedListBox.SetItemChecked(i, true);
                        break;
                    }
                }
            });
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
            ModelDeletedEvent?.Invoke(this, _sage);
            Close();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            _sage.Name = sageNameTextBox.Text;
            _sage.Age = (int)sageAgeNumericUpDown.Value;
            _sage.City = sageCityListBox.Text;
            _sage.Books = sageBooksCheckedListBox.CheckedItems.Cast<Book>().ToList();

            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                using var ms = new MemoryStream();
                ms.Seek(0, SeekOrigin.Begin);
                sagePhotoPictureBox.Image.Save(ms, ImageFormat.Png);
                _sage.Photo = ms.ToArray();
            }

            if (IsEditMode)
            {
                ModelUpdatedEvent?.Invoke(this, _sage);
            }
            else
            {
                ModelCreatedEvent?.Invoke(this, _sage);
            }

            Close();
        }
    }
}
