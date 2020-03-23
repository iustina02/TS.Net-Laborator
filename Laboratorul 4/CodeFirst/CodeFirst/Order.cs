using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CodeFirst
{
    public partial class Order
    {
        public int OrderId { get; set; }
        [MaxLength(20)]
        public DateTime Date { get; set; }
        public int Value { get; set; }

        public int Payed { get; set; }

        public int ClientID { get; set; }

        public int Deleted { get; set; }

        protected Order() { }

        public Client Client { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
