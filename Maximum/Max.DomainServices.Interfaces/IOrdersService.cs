using Max.Entities;

namespace Max.DomainServices.Interfaces
{
    internal interface IOrdersService
    {
        decimal GetPrice(Order order);
    }
}
