using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class BookCopyService:IService
    {
        BookCopyRepository _bookCopyRepository;

        public BookCopyService(RepositoryFactory repoFactory)
        {
            _bookCopyRepository = repoFactory.GetBookCopyRepository();
        }

        public event EventHandler Updated;

        protected virtual void OnUpdate(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public IEnumerable<BookCopy> All()
        {
            return _bookCopyRepository.All();
        }

        public void RemoveCopy(BookCopy copy)
        {
            _bookCopyRepository.Remove(copy);
            OnUpdate(new EventArgs());
        }
    }
}
