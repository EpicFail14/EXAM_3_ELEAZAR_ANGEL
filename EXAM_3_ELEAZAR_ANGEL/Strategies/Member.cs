using EXAM_3_ELEAZAR_ANGEL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Strategies
{
    public class Member
    {
        public int Id { get; set; }

        // 🔹 NEW NAME STRUCTURE
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleInitial { get; set; } = string.Empty;
        public List<Book> Books { get; set; } = new List<Book>();

        // 🔹 TYPE (Student / Faculty / Guest)
        public string Type { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        // 🔹 STRATEGY
        private ILateFeeStrategy? _strategy;

        public Member() { } // EF Core

        public Member(ILateFeeStrategy strategy)
        {
            _strategy = strategy;
        }

        // 🔹 FULL NAME (AUTO FORMAT)
        public string FullName => $"{LastName}, {FirstName} {MiddleInitial}".Trim();

        public double CalculateFee(int days)
        {
            if (_strategy == null)
                return 0;

            return _strategy.CalculateFee(days);
        }
    }
}
