using System;
using System.Collections.Generic;

namespace Ultra.Entities.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public ICollection<OrderItem> Items { get; set; }
    }
}
