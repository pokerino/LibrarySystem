using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library {
    public partial class LibraryForm : Form
    {
        AuthorService _authorService;
        BookService _bookService;
        BookCopyService _bookCopyService;
        LoanService _loanService;
        MemberService _memberService;
        RepositoryFactory RepoFactory = new RepositoryFactory();

        public LibraryForm()
        {
            InitializeComponent();
            _authorService = new AuthorService(RepoFactory);
            _bookService = new BookService(RepoFactory);
            _bookCopyService = new BookCopyService(RepoFactory);
            _loanService = new LoanService(RepoFactory);
            _memberService = new MemberService(RepoFactory);

            _bookService.Updated += bookService_change;
            _memberService.Updated += memberService_change;
            _loanService.Updated += loanService_change;
            _authorService.Updated += authorService_change;
            _bookCopyService.Updated += bookCopyService_change;

            loanComboBox.SelectedIndex = 0;
            ListAll();
        }

        private void bookService_change(object sender, EventArgs e)
        {
            updateBookList();
        }

        private void memberService_change(object sender, EventArgs e)
        {
            updateMemberList();
        }

        private void loanService_change(object sender, EventArgs e)
        {
            updateLoanList();
            updateBookList();
        }
        private void authorService_change(object sender, EventArgs e)
        {
            updateAuthorList();
        }

        private void bookCopyService_change(object sender, EventArgs e)
        {
            updateBookList();
            updateBookCopyList();
        }

        private void ListAll()
        {
            updateMemberList();
            updateBookList();
            updateAuthorList();
            updateLoanList();
        }

        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                loanBtn.Enabled = true;
            }
            else
                loanBtn.Enabled = false;
            updateBookInfo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                loanBtn.Enabled = true;
            }
            else
                loanBtn.Enabled = false;
            updateMemberInfo();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            if (isNumbers(yearField.Text))
                _bookService.Add(titleField.Text, (Author)authorComboBox.SelectedItem, ISBNField.Text, descField.Text, Convert.ToInt32(yearField.Text));
            else
                System.Windows.Forms.MessageBox.Show("Please type in a year using only numbers");
        }

        private void AddMember_Click(object sender, EventArgs e)
        {
            if(isNumbers(memberIdField.Text))
                _memberService.Add(Convert.ToInt64(memberIdField.Text), memberNameField.Text);
            else
                System.Windows.Forms.MessageBox.Show("Please type in correct Personal number");
        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            _authorService.Add(authorNameField.Text);
        }

        private void updateAuthorList()
        {
            lbAuthor.Items.Clear();
            authorComboBox.Items.Clear();
            foreach(Author author in _authorService.All())
            {
                lbAuthor.Items.Add(author);
                authorComboBox.Items.Add(author);
            }
        }

        private void updateBookList()
        {
            lbBooks.Items.Clear();
            if (lbAuthor.SelectedItem == null || authorChkBox.Checked== false)
            {
                foreach (Book element in _bookService.All())
                {
                    if (element.copies.Exists(b => b.Loan.Equals(false)) || availChkBox.Checked == false)
                        if ((element.Title.ToLower()).Contains(searchField.Text.ToLower()) || (element.author.Name.ToLower()).Contains(searchField.Text.ToLower()))
                            lbBooks.Items.Add(element);
                }                
            }
            if (lbAuthor.SelectedItem != null && authorChkBox.Checked == true)
            {
                foreach (Book element in _bookService.ByAuthor((Author)lbAuthor.SelectedItem))
                {
                    if(element.copies.Exists(b => b.Loan.Equals(false)) || availChkBox.Checked == false)
                        if ((element.Title.ToLower()).Contains(searchField.Text.ToLower()) || (element.author.Name.ToLower()).Contains(searchField.Text.ToLower()))
                            lbBooks.Items.Add(element);
                }
            }
            updateBookInfo();
        }
        private void updateMemberList()
        {
            comboBox1.Items.Clear();
            foreach (Member element in _memberService.All())
            {
                comboBox1.Items.Add(element);
            }
        }

        private void updateLoanList()
        {
            lbLoans.Items.Clear();
            IEnumerable<Loan> loanList= new List<Loan>();
            if(loanComboBox.SelectedIndex.Equals(0))
            {
                editLoanButton.Enabled = true;
                loanList = new List<Loan>(_loanService.ActiveLoans());
            }
            if(loanComboBox.SelectedIndex.Equals(1))
            {
                editLoanButton.Enabled = true;
                loanList = new List<Loan>(_loanService.Overdue());
            }
            if(loanComboBox.SelectedIndex.Equals(2))
            {
                editLoanButton.Enabled = false;
                loanList = new List<Loan>(_loanService.Archive());
            }
            
            foreach (Loan element in loanList)
            {
                lbLoans.Items.Add(element);
            }
            updateBookInfo();
            updateMemberInfo();
        }

        private void updateBookCopyList()
        {
            ISBNField.Text = "";
        }

        private void updateMemberInfo()
        {
            try
            {
                string text = string.Format("{0}\r\nPersonalnr: {1}\r\nLoans: \r\n",
                    ((Member)comboBox1.SelectedItem).Name,
                    ((Member)comboBox1.SelectedItem).personalNr);
                List<Loan> loans = new List<Loan>(_loanService.All().Where(m => m.member.Equals((Member)comboBox1.SelectedItem)).OrderByDescending(d => d.time));
                foreach (Loan element in loans)
                {
                    if (element.bookCopy.Loan == true)
                    {
                        text += string.Format("{0}\r\n - Loan date: {1}\r\n - Due date: {2}\r\n",
                            element.bookCopy,
                            element.time.ToShortDateString(),
                            element.dueDate.ToShortDateString());
                    }
                    else
                    {
                        text += string.Format("{0}\r\n - Loan date: {1}\r\n - Return date: {2}\r\n",
                        element.bookCopy,
                        element.time.ToShortDateString(),
                        element.returnTime.ToShortDateString());
                        if (element.returnTime > element.dueDate)
                            text += string.Format(" - Late: {0} days\r\n",
                                (element.returnTime - element.dueDate).TotalDays);
                    }
                    text += "\r\n";
                }
                textBox2.Text = text;
            }
            catch { }
        }

        private void updateBookInfo()
        {
            string text = "";
            try
            {
                text = _bookService.giveInfo((Book)lbBooks.SelectedItem);
            }
            catch { }
            try
            {
                if (((Book)lbBooks.SelectedItem).copies != null)
                {
                    foreach (BookCopy element in ((Book)lbBooks.SelectedItem).copies)
                    {
                        if (element.Loan == true)
                            text += string.Format("Loaned By: {0}\r\n",
                                _loanService.All().First(m => m.bookCopy.Equals(element)).member);
                    }
                }
            }
            catch { }
            try
            {
                textBox1.Text = text;
                titleField.Text = ((Book)lbBooks.SelectedItem).Title;
                authorComboBox.SelectedItem = ((Book)lbBooks.SelectedItem).author;
                yearField.Text = ((Book)lbBooks.SelectedItem).publishedYear.ToString();
                ISBNField.Text = ((Book)lbBooks.SelectedItem).ISBN;
                descField.Text = ((Book)lbBooks.SelectedItem).desc;
            }
            catch { }
        }

        private void lbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (authorChkBox.Checked == true)
                updateBookList();
        }

        private void authorChkBox_CheckedChanged(object sender, EventArgs e)
        {
            updateBookList();
        }

        private void availChkBox_CheckedChanged(object sender, EventArgs e)
        {
            updateBookList();
        }

        private void loanComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLoanList();
        }

        private void ISBNField_TextChanged(object sender, EventArgs e)
        {
            AddBook.Text = "Add Book";
            RemoveBook.Enabled = false;
            try
            {
                foreach(Book book in _bookService.All())
                {
                    if (ISBNField.Text.Equals(book.ISBN))
                    {
                        AddBook.Text = "Add a Copy";
                        if((book.copies.Where(c => c.Loan.Equals(false))).Count()>0)
                            RemoveBook.Enabled = true;
                        lbBooks.SelectedItem = book;
                    }

                }
            }
            catch{}
        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dueDatePicker.Value = startDatePicker.Value.AddDays(15);
        }

        private void dueDatePicker_ValueChanged(object sender, EventArgs e)
        {
            startDatePicker.Value = dueDatePicker.Value.AddDays(-15);
        }

        private void searchField_TextChanged(object sender, EventArgs e)
        {
            updateBookList();
        }

        private void RemoveBook_Click(object sender, EventArgs e)
        {
            try
            {
                _bookCopyService.RemoveCopy(_bookService.FirstRemove((Book) lbBooks.SelectedItem));
            }
            catch
            {
                //To update List even if problem prevents event to happened.
                updateBookList();
                updateBookCopyList();
            }
        }

        private void loanBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbBooks.SelectedItem != null && comboBox1.SelectedItem != null)
                    _loanService.MakeLoan(new Loan(((Book)lbBooks.SelectedItem).copies.First(c => c.Loan.Equals(false)), (Member)comboBox1.SelectedItem));
            }
            catch { }

        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string message = null;
                if (lbLoans.SelectedItem != null)
                    if (((Loan)lbLoans.SelectedItem).Loaned.Equals(true))
                        message = _loanService.ReturnLoan((Loan)lbLoans.SelectedItem);
                    else
                        MessageBox.Show("Loan already returned!");
                if (message != null)
                    MessageBox.Show(message);
            }
            catch { }

        }

        private void editLoanButton_Click(object sender, EventArgs e)
        {
            try
            {
                _loanService.changeDate((Loan)lbLoans.SelectedItem, startDatePicker.Value, dueDatePicker.Value);
            }
            catch { }
        }

        bool isNumbers(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            if (str.Length == 0)
                return false;
            else
                return true;
        }
    }
}
