using System;
using System.Collections.Generic;

namespace Max.Entities.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public ICollection<OrderItem> Items { get; private set; } = new HashSet<OrderItem>();
    }
}
