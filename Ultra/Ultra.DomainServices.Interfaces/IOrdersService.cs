using Ultra.Common.Domain.Entities.Models;

namespace Ultra.Common.Domain.Services.Interfaces
{
    public interface IOrdersService
    {
        decimal GetPrice(Order order);
    }
}
