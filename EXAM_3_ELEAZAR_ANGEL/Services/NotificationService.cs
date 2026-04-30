using EXAM_3_ELEAZAR_ANGEL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Services
{
    public class NotificationService
    {
        public void Subscribe(LibraryService service)
        {
            service.OnBookCheckedOut += HandleCheckout;
        }

        private void HandleCheckout(Book book)
        {
            Console.WriteLine($"Notification: {book.Title} checked out");
        }
    }
}
