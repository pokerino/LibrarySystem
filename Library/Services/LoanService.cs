using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    class LoanService
    {
        LoanRepository _loanRepository;

        public LoanService(RepositoryFactory repoFactory)
        {
            _loanRepository = repoFactory.GetLoanRepository();
        }

        public event EventHandler Updated;

        protected virtual void OnUpdate(EventArgs e)
        {
            if (Updated != null)
                Updated(this, e);
        }

        public IEnumerable<Loan> All()
        {
            return _loanRepository.All();
        }

        public IEnumerable<Loan> Overdue()

        {
            return _loanRepository.Overdue();
        }

        public IEnumerable<Loan> Archive()
        {
            return _loanRepository.Archive();
        }

        public IEnumerable<Loan> ActiveLoans()
        {
            return _loanRepository.ActiveLoans();
        }

        public void MakeLoan(Loan loan)
        {
            _loanRepository.Add(loan);
            OnUpdate(new EventArgs());
        }

        public void changeDate(Loan loan, DateTime loaned, DateTime due)
        {
            loan.time = loaned;
            loan.dueDate = due;
            _loanRepository.Edit(loan);
            OnUpdate(new EventArgs());
        }

        public string ReturnLoan(Loan loan)
        {
            loan.Return();
            _loanRepository.Edit(loan);
            OnUpdate(new EventArgs());
            if (loan.dueDate < (DateTime.Now))
            {
                return string.Format("Need to pay: {0} kr.", (DateTime.Now - loan.dueDate).Days*10);
            }
            else
            {
                return null;
            }
        }
    }
}
