using Ultra.Entities.Models;

namespace Ultra.DomainServices.Interfaces
{
    public interface IOrdersService
    {
        decimal GetPrice(Order order);
    }
}
