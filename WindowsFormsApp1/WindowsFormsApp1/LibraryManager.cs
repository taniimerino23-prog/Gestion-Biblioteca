using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp1
{
    public class LibraryManager
    {
        public List<Book> Books { get; private set; }
        public List<User> Users { get; private set; }
        public List<Loan> Loans { get; private set; }

        private int nextBookId = 1;
        private int nextUserId = 1;
        private int nextLoanId = 1;

        public LibraryManager()
        {
            Books = new List<Book>();
            Users = new List<User>();
            Loans = new List<Loan>();
        }

        // ================== LIBROS ==================
        public void AddBook(Book book)
        {
            book.Id = nextBookId++;
            Books.Add(book);
        }

        // ================== USUARIOS ==================
        public void AddUser(User user)
        {
            user.Id = nextUserId++;
            Users.Add(user);
        }

        // ================== PRÉSTAMOS ==================
        public void AddLoan(int bookId, int userId)
        {
            var loan = new Loan
            {
                Id = nextLoanId++,
                BookId = bookId,
                UserId = userId,
                LoanDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(7) // 7 días de préstamo
            };

            Loans.Add(loan);
        }

        public void ReturnLoan(int loanId)
        {
            var loan = Loans.FirstOrDefault(l => l.Id == loanId);
            if (loan != null)
            {
                Loans.Remove(loan);
            }
        }
    }
}
