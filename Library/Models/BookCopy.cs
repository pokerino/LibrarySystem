using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class BookCopy
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual Book Book { get; set; }
        public bool Loan { get; set; }

        public override string ToString()
        {
            return Book.Title;
        }

        public BookCopy()
        {
            Loan = false;
        }

        public BookCopy(Book book)
        {
            Book = book;
            Loan = false;
        }
    }
}
