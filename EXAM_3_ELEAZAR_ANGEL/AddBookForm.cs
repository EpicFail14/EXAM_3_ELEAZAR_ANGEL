using EXAM_3_ELEAZAR_ANGEL.Models;

namespace EXAM_3_ELEAZAR_ANGEL
{
    public partial class AddBookForm : Form
    {
        public Book? NewBook { get; private set; }
        public string AuthorName => txtAuthors.Text;
        public string Title => txtTitle.Text;
        public string Isbn => txtISBN.Text;
        public int Year => int.Parse(txtYear.Text);
        public int Quantity => int.Parse(txtQuantity.Text);
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required");
                return;
            }

            NewBook = new Book
            {
                Title = txtTitle.Text,
                Isbn = txtISBN.Text,
                Year = int.Parse(txtYear.Text),
                Quantity = int.Parse(txtQuantity.Text),
                Status = "Available",
                AuthorsText = txtAuthors.Text // simple authors
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}