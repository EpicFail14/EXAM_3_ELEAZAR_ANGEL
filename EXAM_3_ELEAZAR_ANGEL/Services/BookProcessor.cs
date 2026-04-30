using EXAM_3_ELEAZAR_ANGEL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Services
{
    public class BookProcessor
    {
        public void Process(List<Book> books)
        {
            var validBooks = books.Where(b =>
                b.Status == "Available" &&
                !b.IsReference &&
                b.Year > 2000);

            foreach (var b in validBooks)
            {
                // do logic
                System.Console.WriteLine(b.Title);
            }
        }
    }
}
