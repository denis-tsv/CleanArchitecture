using Max.DomainServices.Interfaces;
using System.Linq;
using Max.Entities;

namespace Max.DomainServices.Implementation
{
    public class OrdersService : IOrdersService
    {
        public decimal GetPrice(Order order)
        {
            return order.Items.Sum(x => x.Count * x.Product.Price);
        }
    }
}
