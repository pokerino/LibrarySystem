using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;
using Library.Services;

namespace Library.Repositories
{
    public class BookRepository:IRepository<Book, int>
    {
        private LibraryContext _context;

        public BookRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Book> All()
        {
            return _context.Books;
        }

        public IEnumerable<Book> ByAuthor(Author author)
        {
            return _context.Books.Where(a => a.author.Id.Equals(author.Id));
        }

        public BookCopy FirstRemove(Book book)
        {
            return (_context.Books.First(b => b.Id.Equals(book.Id))).copies.First(l => l.Loan.Equals(false));
        }

        public void Add(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Remove(Book book)
        {
            _context.Books.Remove(_context.Books.Find(book.Id));
            _context.SaveChanges();
        }

        public void Edit(Book dataChange)
        {
            Book bookTarget = _context.Books.Find(dataChange.Id);
            bookTarget.Title = dataChange.Title;
            bookTarget.ISBN = dataChange.ISBN;
            bookTarget.desc = dataChange.desc;
            bookTarget.author = dataChange.author;
            bookTarget.publishedYear = dataChange.publishedYear;
        }

        public Book Find(int book)
        {
            return _context.Books.Find(book);     
        }
    }
}