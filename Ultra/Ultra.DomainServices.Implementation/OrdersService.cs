using System.Linq;
using Ultra.DomainServices.Interfaces;
using Ultra.Entities.Models;

namespace Ultra.DomainServices.Implementation
{
    public class OrdersService : IOrdersService
    {
        public decimal GetPrice(Order order)
        {
            return order.Items.Sum(x => x.Count * x.Product.Price);
        }
    }
}
