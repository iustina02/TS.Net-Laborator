using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFirst
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Stock { get; set; }

        public decimal Price { get; set; }

        public int Deleted { get; set; }

        public int OrderDetailsId { get; set; }

        public Product() { }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
