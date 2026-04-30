using System;
using System.Collections.Generic;
using System.Text;

namespace EXAM_3_ELEAZAR_ANGEL.Data
{
    using EXAM_3_ELEAZAR_ANGEL.Models;
    using EXAM_3_ELEAZAR_ANGEL.Strategies;
    using Microsoft.EntityFrameworkCore;

    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Borrow> Borrows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=LibraryDB_FINAL;;Trusted_Connection=True;"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // MANY-TO-MANY
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books);

            // UNIQUE ISBN
            modelBuilder.Entity<Book>()
                .HasIndex(b => b.Isbn)
                .IsUnique();

            // CONCURRENCY
            modelBuilder.Entity<Book>()
                .Property(b => b.RowVersion)
                .IsRowVersion();

        }
    }
}
