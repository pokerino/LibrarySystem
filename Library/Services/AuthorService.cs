using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class AuthorService:IService
    {
        AuthorRepository _authorRepository;

        public AuthorService(RepositoryFactory repoFactory)
        {
            //Laddar in..
            _authorRepository = repoFactory.GetAuthorRepository();
        }

        public IEnumerable<Author> All()
        {
            return _authorRepository.All();
        }

        public event EventHandler Updated;

        protected virtual void OnUpdate(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public void Add(string name)
        {
            if(name == null || name.Length < 5 || name.Length > 25)
            {
                System.Windows.Forms.MessageBox.Show("Please type a name between 5 and 25 characters");
            }
            else
            {
                _authorRepository.Add(new Author()
                {
                    Name = name
                });
            }

            OnUpdate(new EventArgs());
        }
    }
}
