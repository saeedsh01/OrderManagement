using OrderManagement.Core.Domain.Orders.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace OrderManagement.Core.Contracts.Orders.Commands
{
    public interface IOrderCommandRepository : ICommandRepository<Order, long>
    {
    }
}
