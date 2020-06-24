using System.Linq;
using Ultra.Common.Domain.Entities.Models;
using Ultra.Common.Domain.Services.Interfaces;

namespace Ultra.Common.Domain.Services.Implementation
{
    public class OrdersService : IOrdersService
    {
        public decimal GetPrice(Order order)
        {
            return order.Items.Sum(x => x.Count * x.Product.Price);
        }
    }
}
