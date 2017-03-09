using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string desc { get; set; }
        public virtual Author author { get; set; }
        public int publishedYear { get; set; }
//        public int nrCopies { get; set; }
        public virtual List<BookCopy> copies { get; set; }

        public override string ToString()
        {
            return String.Format("[{0}] -- {1}, by {2}. Copies: {3}", this.Id, this.Title, this.author, this.copies.Count);
        }

        public Book()
        {
            copies = new List<BookCopy>();
            this.AddCopy();
        }

        public void AddCopy()
        {
            copies.Add(new BookCopy(this));
        }

        public void AddCopy(int nmr)
        {
            for (int i= 0; i < nmr; i++)
                copies.Add(new BookCopy(this));                
        }
    }
}