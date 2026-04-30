using EXAM_3_ELEAZAR_ANGEL.Data;
using EXAM_3_ELEAZAR_ANGEL.Models;
using EXAM_3_ELEAZAR_ANGEL.Services;
using EXAM_3_ELEAZAR_ANGEL.Strategies;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;

namespace EXAM_3_ELEAZAR_ANGEL
{
    public partial class Form1 : Form
    {
        private LibraryContext _context;
        private LibraryService _libraryService;
        public Form1()
        {
            InitializeComponent();

            _context = new LibraryContext();
            _libraryService = new LibraryService(_context);

            var notificationService = new NotificationService();
            notificationService.Subscribe(_libraryService);
        }
        private double GetFee(Member member, int days)
        {
            if (member.Type == "Student")
                return days * 2.0;
            else if (member.Type == "Faculty")
                return days * 0.5;
            else
                return days * 3.0;
        }
        private void ShowPanel(Panel panelToShow)
        {
            panelDashboard.Visible = false;
            panelBooks.Visible = false;
            panelAuthors.Visible = false;
            panelMembers.Visible = false;

            panelToShow.Visible = true;
        }
        private void LoadBooks()
        {
            gridBooks.Rows.Clear();

            var books = _context.Books.ToList();

            foreach (var b in books)
            {
                gridBooks.Rows.Add(
                    b.Id,
                    b.Title,
                    b.Isbn,
                    b.Year,
                    b.Status,
                    b.Quantity
                );
            }
        }
        private void btnBooks_Click(object sender, EventArgs e)
        {
            ShowPanel(panelBooks);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(panelDashboard);
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            ShowPanel(panelAuthors);
            LoadAuthors();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            ShowPanel(panelMembers);
            LoadMembers();
        }
        private void UpdateDashboard()
        {
            var books = _context.Books.ToList();
            var members = _context.Members.ToList();

            lblTotalBooks.Text = books.Count.ToString();

            lblActiveMembers.Text = members.Count(m => m.IsActive).ToString();

            lblCheckedOut.Text = _context.Borrows
                .Count(b => !b.IsReturned)
                .ToString();

            lblOverdue.Text = "0";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _context.Database.EnsureCreated();

            LoadBooks();
            LoadMembers();
            UpdateDashboard();

            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

            LoadSearchSuggestions();

            ShowPanel(panelDashboard);
        }
        private void LoadSearchSuggestions()
        {
            var auto = new AutoCompleteStringCollection();

            foreach (var m in _context.Members)
            {
                auto.Add($"{m.LastName}, {m.FirstName}");
                auto.Add(m.FirstName);
                auto.Add(m.LastName);
                auto.Add(m.Type);
            }

            foreach (var b in _context.Books)
            {
                auto.Add(b.Title);
                auto.Add(b.Isbn);
                auto.Add(b.Year.ToString());
                auto.Add(b.Status);
            }

            foreach (var a in _context.Authors)
            {
                auto.Add(a.Name);
            }

            txtSearch.AutoCompleteCustomSource = auto;
        }
        private async void btnCheckout_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookId.Text, out int bookId))
            {
                MessageBox.Show("Invalid Book ID");
                return;
            }

            var form = new CheckoutForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var member = _context.Members.FirstOrDefault(m =>
                        m.LastName == form.LastName &&
                        m.FirstName == form.FirstName &&
                        m.MiddleInitial == form.MiddleInitial
                    );

                    if (member == null)
                    {
                        member = new Member
                        {
                            LastName = form.LastName,
                            FirstName = form.FirstName,
                            MiddleInitial = form.MiddleInitial,
                            Type = form.MemberType,
                            IsActive = true
                        };

                        _context.Members.Add(member);
                        _context.SaveChanges();
                    }
                    else
                    {
                        member.IsActive = true;
                    }

                    double fee = GetFee(member, 1);

                    var confirm = MessageBox.Show(
                        $"Borrow Fee: ₱{fee}\nProceed?",
                        "Confirm Payment",
                        MessageBoxButtons.YesNo);

                    if (confirm != DialogResult.Yes)
                        return;

                    string paymentInput = Microsoft.VisualBasic.Interaction.InputBox(
                        $"Enter payment (₱{fee}):",
                        "Payment Required",
                        fee.ToString());

                    if (!double.TryParse(paymentInput, out double payment) || payment < fee)
                    {
                        MessageBox.Show("Insufficient payment!");
                        return;
                    }

                    await _libraryService.CheckoutBookAsync(bookId);

                    _context.Borrows.Add(new Borrow
                    {
                        BookId = bookId,
                        MemberId = member.Id,
                        IsReturned = false,
                        BorrowDate = DateTime.Now
                    });

                    _context.SaveChanges();

                    LoadBooks();
                    LoadMembers();
                    UpdateDashboard();

                    MessageBox.Show($"Checked out by {member.FullName}\nPaid: ₱{fee}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int days = int.Parse(txtDays.Text);

            ILateFeeStrategy strategy;

            if (cmbMemberType.Text == "Student")
                strategy = new StudentFeeStrategy();
            else if (cmbMemberType.Text == "Faculty")
                strategy = new FacultyFeeStrategy();
            else
                strategy = new GuestFeeStrategy();

            var member = new Member(strategy);

            double fee = member.CalculateFee(days);

            lblFee.Text = $"Fee: ${fee}";
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var form = new AddBookForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var book = new Book
                {
                    Title = form.Title,
                    Isbn = form.Isbn,
                    Year = form.Year,
                    Quantity = form.Quantity,
                    Status = "Available"
                };

                var authorNames = form.AuthorName.Split(',');

                var authors = new List<Author>();

                foreach (var name in authorNames)
                {
                    string clean = name.Trim();

                    if (string.IsNullOrWhiteSpace(clean))
                        continue;

                    var existing = _context.Authors
                        .FirstOrDefault(a => a.Name == clean);

                    if (existing == null)
                    {
                        existing = new Author { Name = clean };
                        _context.Authors.Add(existing);
                    }

                    authors.Add(existing);
                }

                book.Authors = authors;

                _context.Books.Add(book);
                _context.SaveChanges();

                LoadBooks();
                UpdateDashboard();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a book first");
                return;
            }

            int id = Convert.ToInt32(gridBooks.SelectedRows[0].Cells["colId"].Value);

            var book = _context.Books.Find(id);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();

                LoadBooks();
                UpdateDashboard();
            }
        }
        private void txtSearchBooks_TextChanged(object sender, EventArgs e)
        {
            var search = txtSearchBooks.Text.ToLower();

            var books = _context.Books
                .Where(b => b.Title.ToLower().Contains(search))
                .ToList();

            gridBooks.Rows.Clear();

            foreach (var b in books)
            {
                gridBooks.Rows.Add(
                    b.Id,
                    b.Title,
                    b.Isbn,
                    b.Year,
                    b.Status,
                    b.Quantity
                );
            }
        }
        private void LoadAuthors()
        {
            gridAuthors.Rows.Clear();

            var authors = _context.Authors
                .Include(a => a.Books)
                .ToList();

            foreach (var a in authors)
            {
                gridAuthors.Rows.Add(
                    a.Name,
                    a.Books != null ? a.Books.Count : 0
                );
            }
        }
        private void LoadMembers()
        {
            gridMembers.Rows.Clear();

            var members = _context.Members.ToList();

            foreach (var m in members)
            {
                string fullName = m.LastName + ", " + m.FirstName;

                var borrows = _context.Borrows
                    .Where(b => b.MemberId == m.Id && !b.IsReturned)
                    .ToList();

                var bookTitles = borrows
                    .Select(b => _context.Books.Find(b.BookId)?.Title)
                    .Where(t => t != null)
                    .ToList();

                string status = borrows.Count > 0 ? "Active" : "Inactive";

                string booksText = bookTitles.Count > 0
                    ? string.Join(", ", bookTitles)
                    : "None";

                string timeline = "No Borrow";

                if (borrows.Count > 0)
                {
                    var b = borrows[0];

                    DateTime dueDate = b.BorrowDate.AddDays(7 + b.ExtendedDays);

                    if (DateTime.Now > dueDate)
                    {
                        int overdueDays = (DateTime.Now - dueDate).Days;
                        timeline = $"Overdue ({overdueDays} days)";
                    }
                    else
                    {
                        timeline = $"Due: {dueDate.ToShortDateString()}";
                    }
                }

                gridMembers.Rows.Add(
                    m.Id,
                    fullName,
                    m.Type,
                    status,
                    booksText,
                    timeline
                );
            }
        }

        private void gridMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var cellValue = gridMembers.Rows[e.RowIndex].Cells["colMemberId"].Value;

            if (cellValue == null || !int.TryParse(cellValue.ToString(), out int memberId))
            {
                MessageBox.Show("Invalid member");
                return;
            }

            var form = new MemberDetailsForm(memberId, _context);
            form.ShowDialog();

            LoadMembers();
            LoadBooks();
            UpdateDashboard();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadMembers();
                return;
            }

            gridMembers.Rows.Clear();

            var members = _context.Members.ToList();

            foreach (var m in members)
            {
                string fullName = (m.LastName + ", " + m.FirstName).ToLower();

                var borrows = _context.Borrows
                    .Where(b => b.MemberId == m.Id && !b.IsReturned)
                    .ToList();

                var books = borrows
                    .Select(b => _context.Books.Find(b.BookId)?.Title ?? "")
                    .ToList();

                string booksText = string.Join(", ", books).ToLower();

                string type = m.Type.ToLower();

                string status = borrows.Count > 0 ? "active" : "inactive";

                DateTime dueDate = borrows.Count > 0
                    ? borrows[0].BorrowDate.AddDays(7 + borrows[0].ExtendedDays)
                    : DateTime.Now;

                string timeline = borrows.Count > 0
                    ? (DateTime.Now > dueDate
                        ? $"Overdue ({(DateTime.Now - dueDate).Days}d)"
                        : $"Due: {dueDate:MM/dd/yyyy}")
                    : "None";

                if (fullName.Contains(keyword) ||
                    booksText.Contains(keyword) ||
                    type.Contains(keyword) ||
                    status.Contains(keyword))
                {
                    gridMembers.Rows.Add(
                        m.Id,
                        m.LastName + ", " + m.FirstName,
                        m.Type,
                        status,
                        booksText,
                        timeline
                    );
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txtSearch.Text.Trim().ToLower().Replace(",", "");

                if (string.IsNullOrEmpty(keyword)) return;


                var members = _context.Members.ToList();

                Member? foundMember = null;

                foreach (var m in members)
                {
                    string full1 = (m.LastName + " " + m.FirstName).ToLower();
                    string full2 = (m.LastName + ", " + m.FirstName).ToLower();
                    string full3 = (m.LastName + ", " + m.FirstName + " " + (m.MiddleInitial ?? "")).ToLower();

                    if (full1.Contains(keyword) ||
                        full2.Contains(keyword) ||
                        full3.Contains(keyword) ||
                        m.LastName.ToLower().Contains(keyword) ||
                        m.FirstName.ToLower().Contains(keyword))
                    {
                        foundMember = m;
                        break;
                    }
                }

                if (foundMember != null)
                {
                    ShowPanel(panelMembers);
                    LoadMembers();
                    return;
                }

                var book = _context.Books
                    .FirstOrDefault(b => b.Title.ToLower().Contains(keyword));

                if (book != null)
                {
                    ShowPanel(panelBooks);
                    LoadBooks();
                    return;
                }

                var author = _context.Authors
                    .FirstOrDefault(a => a.Name.ToLower().Contains(keyword));

                if (author != null)
                {
                    ShowPanel(panelAuthors);
                    LoadAuthors();
                    return;
                }

                MessageBox.Show("No results found.");
            }
        }

        private void txtSearchBooks_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = txtSearchBooks.Text.Trim().ToLower();

            gridBooks.Rows.Clear();

            var books = _context.Books.ToList();

            foreach (var b in books)
            {
                if (
                    b.Title.ToLower().Contains(keyword) ||
                    b.Isbn.ToLower().Contains(keyword) ||
                    b.Year.ToString().Contains(keyword) ||
                    b.Status.ToLower().Contains(keyword)
                )
                {
                    gridBooks.Rows.Add(
                        b.Id,
                        b.Title,
                        b.Isbn,
                        b.Year,
                        b.Status,
                        b.Quantity
                    );
                }
            }
        }

        private void txtSearchBooks_KeyDown(object sender, KeyEventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var books = _context.Books.ToList();

            Book? foundBook = null;

            foreach (var b in books)
            {
                string title = b.Title.ToLower();
                string isbn = b.Isbn.ToLower();
                string year = b.Year.ToString();
                string status = b.Status.ToLower();

                if (title.Contains(keyword) ||
                    isbn.Contains(keyword) ||
                    year.Contains(keyword) ||
                    status.Contains(keyword))
                {
                    foundBook = b;
                    break;
                }
            }

            if (foundBook != null)
            {
                ShowPanel(panelBooks);
                LoadBooks();
                return;
            }
        }

        private void txtSearchBooks_Enter(object sender, EventArgs e)
        {
            if (txtSearchBooks.Text == "Search books...")
            {
                txtSearchBooks.Text = "";
                txtSearchBooks.ForeColor = Color.Black;
            }
        }

        private void txtSearchBooks_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchBooks.Text))
            {
                txtSearchBooks.Text = "Search books...";
                txtSearchBooks.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtBookId_Enter(object sender, EventArgs e)
        {
            if (txtBookId.Text == "Enter Book ID")
            {
                txtBookId.Text = "";
                txtBookId.ForeColor = Color.Black;
            }
        }

        private void txtBookId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text))
            {
                txtBookId.Text = "Enter Book ID";
                txtBookId.ForeColor = Color.Gray;
            }
        }

        private void txtDays_Enter(object sender, EventArgs e)
        {
            if (txtDays.Text == "Enter Days")
            {
                txtDays.Text = "";
                txtDays.ForeColor = Color.Black;
            }
        }
        private void txtDays_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDays.Text))
            {
                txtDays.Text = "Enter Days";
                txtDays.ForeColor = Color.Gray;
            }
        }
    }
}
