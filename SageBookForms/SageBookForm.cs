using DataAccess;

namespace SageBookForms
{
    public partial class SageBookForm : Form
    {
        private readonly SageBookDbContext _context;

        public SageBookForm()
        {
            _context = new SageBookDbContext();
            InitializeComponent();
        }

        private void SageBookForm_Load(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = _context.Books.ToList();
        }
    }
}