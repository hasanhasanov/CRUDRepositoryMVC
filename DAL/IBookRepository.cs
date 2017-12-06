using System;
using System.Collections.Generic;
using BookStore.Models;

namespace BookStore.DAL
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();
        Book GetBookByID(int bookId);        
        void InsertBook(Book book);        
        void DeleteBook(int bookID);
        void UpdateBook(Book book);
        void Save();        
    }
}