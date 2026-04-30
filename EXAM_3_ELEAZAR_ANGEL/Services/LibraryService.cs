using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using EXAM_3_ELEAZAR_ANGEL.Data;
using EXAM_3_ELEAZAR_ANGEL.Models;

namespace EXAM_3_ELEAZAR_ANGEL.Services
{
    public class LibraryService
    {
        private readonly LibraryContext _context;
        private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public event Action<Book>? OnBookCheckedOut;

        public LibraryService(LibraryContext context)
        {
            _context = context;
        }

        public async Task CheckoutBookAsync(int bookId)
        {
            await _semaphore.WaitAsync(); 

            try
            {
                var book = await _context.Books.FindAsync(bookId);

                if (book == null)
                    throw new Exception("Book not found");

                if (book.Quantity <= 0)
                    throw new Exception("No copies left");

                book.Quantity--;
                book.Status = book.Quantity == 0 ? "Not Available" : "Available";

                await _context.SaveChangesAsync();

                OnBookCheckedOut?.Invoke(book);

                _ = SendEmailAsync(book);

                File.AppendAllText("log.txt",
                    $"{DateTime.Now}: {book.Title} checked out\n");
            }
            finally
            {
                _semaphore.Release(); 
            }
        }

        private async Task SendEmailAsync(Book book)
        {
            await Task.Delay(3000); 

            MessageBox.Show($"Email sent: {book.Title}");
        }
    }
}