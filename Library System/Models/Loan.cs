using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    internal class Loan
    {
        public int BookId { get; set; } 
        public Book Book { get; set; } = null!;

        public int BorrowerId { get; set; } 
        public Borrower Borrower { get; set; } = null!;

        public DateTime LoanDate { get; set; } 
        public DateTime ReturnDate { get; set; } 
    }
}
