using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public Author()
        {
            Books = new List<Book>();
        }
    }
}
