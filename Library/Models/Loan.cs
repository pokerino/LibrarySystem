using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime time { get; set; }
        public DateTime dueDate { get; set; }
        public DateTime returnTime { get; set; }
        public virtual BookCopy bookCopy { get; set; }
        public virtual Member member { get; set; }
        public bool Loaned { get; set; }

        public override string ToString()
        {
            if(Loaned.Equals(true))
                return
                    string.Format("Loaned: {0} - Due: {1} - By: {2} - Book: {3}",
                                 time.ToShortDateString(),
                                 dueDate.ToShortDateString(),
                                 member,
                                 bookCopy.Book.Title);
            else
                return
                    string.Format("Loaned: {0} - Returned: {1} - By: {2} - Book: {3}",
                                 time.ToShortDateString(),
                                 returnTime.ToShortDateString(),
                                 member,
                                 bookCopy.Book.Title);
        }

        public Loan()
        {
            
        }

        public Loan(BookCopy copy, Member member)
        {
            this.DoSpecLoan(copy, member);
        }

        public void DoALoan(Book book, Member person)
        {
            time = DateTime.Today;
            dueDate = DateTime.Today.AddDays(15);
            bookCopy = book.copies.Find(l => l.Loan == false);
            bookCopy.Loan = true;
            member = person;
            returnTime = DateTime.MaxValue;
            Loaned = true;
        }

        public void DoSpecLoan(BookCopy copy, Member person)
        {
            time = DateTime.Today;
            dueDate = DateTime.Today.AddDays(15);
            bookCopy = copy;
            bookCopy.Loan = true;
            member = person;
            returnTime = DateTime.MaxValue;
            Loaned = true;
        }

        public void Return()
        {
            returnTime = DateTime.Today;
            bookCopy.Loan = false;
            Loaned = false;
        }
    }
}
