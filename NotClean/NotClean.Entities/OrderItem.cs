using System;
using System.ComponentModel.DataAnnotations;

namespace NotClean.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        [Required]
        public Order Order { get; set; }


        public int ProductId { get; set; }

        [Required]
        public Product Product { get; set; }

        [Range(1, Int32.MaxValue)]
        public int Count { get; set; }
    }
}
