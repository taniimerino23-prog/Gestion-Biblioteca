using System;

namespace WindowsFormsApp1
{
    public class Loan
    {
        public int Id { get; set; }         // Id numérico
        public int BookId { get; set; }     // referencia al libro
        public int UserId { get; set; }     // referencia al usuario
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
