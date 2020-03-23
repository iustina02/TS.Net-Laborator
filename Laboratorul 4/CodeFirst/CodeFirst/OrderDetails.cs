using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirst
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        [MaxLength(20)]

        public int ProductId { get; set; }

        public decimal Qty { get; set; }

        public decimal Price { get; set; }

        public int Deleted { get; set; }

        public int OrderId { get; set; }

        public OrderDetails() { }
        public Order Order { get; set; }
        public Product Product { get; internal set; }
    }
}
