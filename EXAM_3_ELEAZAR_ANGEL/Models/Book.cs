using EXAM_3_ELEAZAR_ANGEL.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = "";
        public string Isbn { get; set; } = "";
        public string AuthorsText { get; set; } = "";

        public bool IsReference { get; set; }
        public int Year { get; set; }
        public Member? BorrowedBy { get; set; }
        public string Status { get; set; } = "";
        public int Quantity { get; set; }

        public List<Author> Authors { get; set; } = new List<Author>();

        public byte[] RowVersion { get; set; } = new byte[0];
    }
}
