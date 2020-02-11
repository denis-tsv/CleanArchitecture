using Max.Entities.Models;

namespace Max.DomainServices.Interfaces
{
    internal interface IOrdersService
    {
        decimal GetPrice(Order order);
    }
}
