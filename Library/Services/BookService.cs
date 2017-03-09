using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services {
    class BookService : IService
    {
        BookRepository _bookRepository;

        public BookService(RepositoryFactory repoFactory)
        {
            _bookRepository = repoFactory.GetBookRepository();
        }

        public string giveInfo(Book book)
        {
            string text = "";
            if (book != null)
            {
                text = string.Format("{0}\r\nAuthor: {1}\r\nPublished year: {2}\r\nDesciption: {3}\r\nISBN: {4}\r\nNumber of Copies: {5}\r\nCopies available: {6}\r\n",
                    book.Title,
                    book.author,
                    book.publishedYear,
                    book.desc,
                    book.ISBN,
                    book.copies.Count,
                    book.copies.Where(l => l.Loan == false).Count());                
            }

            return text;
        }

        public IEnumerable<Book> All()
        {
            return _bookRepository.All();
        }

        public IEnumerable<Book> ByAuthor(Author author)
        {
            return _bookRepository.ByAuthor(author);
        }

        public BookCopy FirstRemove(Book book)
        {
            return _bookRepository.FirstRemove(book);
        }
        
        public event EventHandler Updated;

        protected virtual void OnUpdate(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }


        public void Add(string bookName, Author Author, string isbn, string description, int? publishedyear)
        {
            bool copyAdded = false;

            foreach (var book in _bookRepository.All())
            {
                if(isbn == book.ISBN)
                {
                    book.AddCopy();
                    copyAdded = true;
                    break;
                }
            }

            if(!copyAdded)
            {
                if (bookName == "" || description == "" || (publishedyear ?? 0) == 0)
                {
                    System.Windows.Forms.MessageBox.Show("You need to fill out all of the fields to add a book");
                }
                else if(Author == null)
                {
                    System.Windows.Forms.MessageBox.Show("Please select an author from the list, if the author is not there you have to add the author first.");
                }
                else if(!validISBN(isbn))
                {
                    System.Windows.Forms.MessageBox.Show("Please enter a valid ISBN");
                }
                else
                {
                    _bookRepository.Add(new Book()
                    {
                        Title = bookName,
                        ISBN = isbn,
                        desc = description,
                        author = Author,
                        publishedYear = (int)publishedyear
                    });
                }

            }
            OnUpdate(new EventArgs());
        }

        public void Remove(Book book)
        {
            _bookRepository.Remove(book);
            OnUpdate(new EventArgs());
        }

        bool validISBN(string str)
        {
            if (str.Length < 10 || str.Length > 17)
                return false;
            else
                return true;
        }

    }
}
