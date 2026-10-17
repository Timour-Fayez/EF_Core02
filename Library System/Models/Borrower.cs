using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    internal class Borrower
    {
        public int Id { get; set; } 
        public string Name { get; set; } = null!; 
        public DateTime MembershipDate { get; set; } 
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
