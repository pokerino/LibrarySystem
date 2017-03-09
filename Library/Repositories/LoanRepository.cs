using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    public class LoanRepository: IRepository<Loan, int>
    {
        private LibraryContext _context;

        public LoanRepository(LibraryContext ctx)
        {
            _context = ctx;
        }

        public void Add(Loan loan)
        {
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }

        public void Remove(Loan loan)
        {
            _context.Loans.Remove(_context.Loans.Find(loan.Id));
        }

        public Loan Find(int loan)
        {
            return _context.Loans.Find(loan);
        }

        public void Edit(Loan loanChange)
        {
            Loan loanTarget = _context.Loans.Find(loanChange.Id);
            loanTarget.bookCopy = loanChange.bookCopy;
            loanTarget.dueDate = loanChange.dueDate;
            loanTarget.member = loanChange.member;
            loanTarget.returnTime = loanChange.returnTime;
            loanTarget.time = loanChange.time;
            _context.SaveChanges();
        }

        public IEnumerable<Loan> All()
        {
            return _context.Loans;
        }

        public IEnumerable<Loan> Overdue()
        {
            return _context.Loans.Where(l => (l.dueDate < (DateTime.Now)) && l.Loaned.Equals(true)).OrderByDescending(d => d.time);
        }

        public IEnumerable<Loan> Archive()
        {
            return _context.Loans.Where(l => l.Loaned.Equals(false)).OrderByDescending(d => d.time);
        }

        public IEnumerable<Loan> ActiveLoans()
        {
            return _context.Loans.Where(l => l.Loaned.Equals(true)).OrderByDescending(d => d.time);
        }

    }
}
