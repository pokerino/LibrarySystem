using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    public class AuthorRepository : IRepository<Author, int>
    {
        private LibraryContext _context;

        public AuthorRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public IEnumerable<Author> All()
        {
            return _context.Authors;
        }

        public void Add(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void Remove(Author author)
        {
            _context.Authors.Remove(_context.Authors.Find(author.Id));
        }

        public Author Find(int author)
        {
            return _context.Authors.Find(author);
        }

        public void Edit(Author author)
        {
            Author authorTarget = _context.Authors.Find(author);
            authorTarget.Name = author.Name;
            authorTarget.Books = author.Books;
        }

    }
}
