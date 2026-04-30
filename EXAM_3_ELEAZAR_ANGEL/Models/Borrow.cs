using EXAM_3_ELEAZAR_ANGEL.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Models
{
    public class Borrow
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book? Book { get; set; }

        public int MemberId { get; set; }
        public Member? Member { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public int ExtendedDays { get; set; } = 0;

        public bool IsReturned { get; set; } = false;
    }
}
