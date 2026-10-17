using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce_System.Models
{
    internal class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public int CategoryId { get; set; } 

        public Category Category { get; set; } = null!;

        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
}
