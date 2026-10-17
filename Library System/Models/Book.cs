using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Models
{
    internal class Book
    {
        public int Id { get; set; } 
        public string Title { get; set; } = null!; 
        public string ISBN { get; set; } = null!;

        public int AuthorId { get; set; } 
        public Author Author { get; set; } = null!;

        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
