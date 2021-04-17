using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class BooksContext: DbContext
    {
        public BooksContext(DbContextOptions options): base(options)
        {
            ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserBook>().HasKey(sc => new { sc.BookId, sc.UserId });
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<UserBook> UserBooks { get; set; }
        //public virtual DbSet<User> Users { get; set; }

    }
}
