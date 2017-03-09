using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    public class BookCopyRepository : IRepository<BookCopy, int>
    {
        private LibraryContext _context;

        public BookCopyRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(BookCopy copy)
        {
            _context.BookCopies.Add(copy);
        }

        public void Remove(BookCopy copy)
        {
            _context.BookCopies.Remove(copy);
            _context.SaveChanges();
        }

        public BookCopy Find(int book)
        {
            return _context.BookCopies.SingleOrDefault(b => b.Id == book);
        }

        public void Edit(BookCopy book)
        {
            BookCopy copiesTarget = _context.BookCopies.Find(book.Id);
            copiesTarget.Book = book.Book;
        }

        public IEnumerable<BookCopy> All()
        {
            return _context.BookCopies;
        }
    }
}
