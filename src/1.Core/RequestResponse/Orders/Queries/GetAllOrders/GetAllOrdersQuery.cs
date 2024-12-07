using OrderManagement.Core.RequestResponse.Orders.QueryResults;
using Zamin.Core.RequestResponse.Queries;

namespace OrderManagement.Core.RequestResponse.Orders.Queries.GetAllOrders
{
    public class GetAllOrdersQuery : IQuery<List<GetAllOrdersQueryResult>>
    {
        public string? CustomerName { get; set; }
    }
}
