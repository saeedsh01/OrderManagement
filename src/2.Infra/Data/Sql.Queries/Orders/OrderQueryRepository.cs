using Microsoft.EntityFrameworkCore;
using OrderManagement.Core.Contracts.Orders.Queries;
using OrderManagement.Core.RequestResponse.Orders.Queries.GetAllOrders;
using OrderManagement.Core.RequestResponse.Orders.QueryResults;
using OrderManagement.Infra.Data.Sql.Queries.Common;
using OrderManagement.Infra.Data.Sql.Queries.Orders.Entity;
using Zamin.Infra.Data.Sql.Queries;

namespace OrderManagement.Infra.Data.Sql.Queries.Orders
{
    public class OrderQueryRepository : BaseQueryRepository<OrderManagementQueryDbContext>, IOrderQueryRepository
    {
        public OrderQueryRepository(OrderManagementQueryDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<GetAllOrdersQueryResult>> ExecuteAsync(GetAllOrdersQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
