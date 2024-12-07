using OrderManagement.Core.Contracts.Orders.Commands;
using OrderManagement.Core.Domain.Orders.Entities;
using OrderManagement.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace OrderManagement.Infra.Data.Sql.Commands.Orders
{
    public class OrderCommandRepository : BaseCommandRepository<Order, OrderManagementCommandDbContext, long>, IOrderCommandRepository
    {
        public OrderCommandRepository(OrderManagementCommandDbContext dbContext) : base(dbContext)
        {
        }
    }
}
