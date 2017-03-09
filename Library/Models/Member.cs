using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public long personalNr { get; set; }
        public string Name { get; set; }
        public ICollection<Loan> Loans { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public Member()
        {
            Loans = new List<Loan>();
        }

        public Member(long pernr, string name)
        {
            personalNr = pernr;
            Name = name;
            Loans = new List<Loan>();
        }
    }
}
