using EXAM_3_ELEAZAR_ANGEL.Data;
using EXAM_3_ELEAZAR_ANGEL.Models;
using EXAM_3_ELEAZAR_ANGEL.Strategies;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EXAM_3_ELEAZAR_ANGEL
{
    public partial class MemberDetailsForm : Form
    {
        private int _memberId;
        private LibraryContext _context;

        public MemberDetailsForm(int memberId, LibraryContext context)
        {
            InitializeComponent();
            _memberId = memberId;
            _context = context;
        }
        private double GetFee(Member member, int days)
        {
            if (member.Type == "Student")
                return days * 2.0;     // ₱2/day
            else if (member.Type == "Faculty")
                return days * 0.5;     // ₱0.50/day
            else
                return days * 3.0;     // ₱3/day (Guest)
        }
        private void MemberDetailsForm_Load(object sender, EventArgs e)
        {
            var member = _context.Members.Find(_memberId);

            if (member == null)
            {
                MessageBox.Show("Member not found");
                return;
            }

            lblName.Text = member.LastName + ", " + member.FirstName;
            lblType.Text = member.Type ?? "";

            var borrows = _context.Borrows
                .Where(b => b.MemberId == _memberId && !b.IsReturned)
                .ToList();

            lstBooks.Items.Clear();

            foreach (var b in borrows)
            {
                var book = _context.Books.Find(b.BookId);
                if (book != null && book.Title != null)
                {
                    lstBooks.Items.Add(b.Id + "-" + book.Title);
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem == null)
            {
                MessageBox.Show("Select a book first");
                return;
            }

            string selected = lstBooks.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(selected))
            {
                MessageBox.Show("Invalid selection");
                return;
            }

            string[] parts = selected.Split('-');

            if (parts.Length == 0 || !int.TryParse(parts[0], out int borrowId))
            {
                MessageBox.Show("Invalid format");
                return;
            }

            var borrow = _context.Borrows.Find(borrowId);

            if (borrow == null)
            {
                MessageBox.Show("Borrow not found");
                return;
            }

            var member = _context.Members.Find(borrow.MemberId);

            // 🔥 CALCULATE DUE DATE
            DateTime dueDate = borrow.BorrowDate.AddDays(7 + borrow.ExtendedDays);

            double fee = 0;

            if (DateTime.Now > dueDate)
            {
                int overdueDays = (DateTime.Now - dueDate).Days;

                if (member != null)
                {
                    fee = GetFee(member, overdueDays);
                }
            }

            // 🔥 REQUIRE PAYMENT IF OVERDUE
            if (fee > 0)
            {
                string paymentInput = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Late fee is ₱{fee}. Enter payment:",
                    "Late Fee Payment",
                    "0");

                if (!double.TryParse(paymentInput, out double payment) || payment < fee)
                {
                    MessageBox.Show("Insufficient payment. Return cancelled.");
                    return;
                }
            }

            // 🔥 MARK RETURNED
            borrow.IsReturned = true;

            // 🔥 UPDATE BOOK
            var book = _context.Books.Find(borrow.BookId);
            if (book != null)
            {
                book.Quantity++;
                book.Status = "Available";
            }

            // 🔥 UPDATE MEMBER STATUS
            bool hasActiveBorrow = _context.Borrows
                .Any(b => b.MemberId == borrow.MemberId && !b.IsReturned);

            if (member != null)
            {
                member.IsActive = hasActiveBorrow;
            }

            _context.SaveChanges();

            MessageBox.Show(fee > 0
                ? $"Book returned!\nPaid: ₱{fee}"
                : "Book returned!");

            MemberDetailsForm_Load(this, EventArgs.Empty);
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem == null)
            {
                MessageBox.Show("Select a book first");
                return;
            }

            string selected = lstBooks.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(selected))
            {
                MessageBox.Show("Invalid selection");
                return;
            }

            string[] parts = selected.Split('-');

            if (parts.Length == 0 || !int.TryParse(parts[0], out int borrowId))
            {
                MessageBox.Show("Invalid book format");
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter number of days to extend:",
                "Extend Book",
                "1");

            if (!int.TryParse(input, out int days) || days <= 0)
            {
                MessageBox.Show("Invalid number of days");
                return;
            }

            var borrow = _context.Borrows.Find(borrowId);

            if (borrow == null)
            {
                MessageBox.Show("Borrow record not found");
                return;
            }

            var member = _context.Members.Find(borrow.MemberId);

            double fee = 0;

            if (member != null)
            {
                fee = GetFee(member, days);
            }

            string paymentInput = Microsoft.VisualBasic.Interaction.InputBox(
                $"Extension fee is ₱{fee}. Enter payment:",
                "Extension Payment",
                "0");

            if (!double.TryParse(paymentInput, out double payment) || payment < fee)
            {
                MessageBox.Show("Insufficient payment. Extension cancelled.");
                return;
            }

            borrow.ExtendedDays += days;

            _context.SaveChanges();

            MessageBox.Show($"Extended {days} days!\nPaid: ₱{fee}");
        }
    }
}