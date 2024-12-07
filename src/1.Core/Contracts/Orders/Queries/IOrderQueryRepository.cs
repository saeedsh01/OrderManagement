using OrderManagement.Core.RequestResponse.Orders.Queries.GetAllOrders;
using OrderManagement.Core.RequestResponse.Orders.QueryResults;
using Zamin.Core.Contracts.Data.Queries;

namespace OrderManagement.Core.Contracts.Orders.Queries
{
    public interface IOrderQueryRepository : IQueryRepository
    {
        Task<List<GetAllOrdersQueryResult>> ExecuteAsync(GetAllOrdersQuery query);
    }
}
