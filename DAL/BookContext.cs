using System.Data.Entity;
using BookStore.Models;

namespace BookStore.DAL
{
    public class BookContext :DbContext
    {
        public BookContext()
            : base("name=BookStoreConnectionString")
        {           
        }

        public DbSet<Book> Books { get; set; }
    }
}