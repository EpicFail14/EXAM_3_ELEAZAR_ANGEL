using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Repositories
{
    using EXAM_3_ELEAZAR_ANGEL.Data;
    using EXAM_3_ELEAZAR_ANGEL.Models;
    using Microsoft.EntityFrameworkCore;

    public class BookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetBooksByAuthorAsync(int authorId)
        {
            return await _context.Books
                .Include(b => b.Authors) 
                .Where(b => b.Authors.Any(a => a.Id == authorId))
                .ToListAsync();
        }
    }
}
