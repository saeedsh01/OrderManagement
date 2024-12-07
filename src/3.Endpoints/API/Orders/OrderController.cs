using Microsoft.AspNetCore.Mvc;
using OrderManagement.Core.RequestResponse.Orders.Commands.AddLine;
using OrderManagement.Core.RequestResponse.Orders.Commands.Create;
using OrderManagement.Core.RequestResponse.Orders.Queries.GetAllOrders;
using OrderManagement.Core.RequestResponse.Orders.QueryResults;
using Zamin.EndPoints.Web.Controllers;

namespace OrderManagement.Endpoints.API.Orders
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OrderController : BaseController
    {
        #region Commands

        [HttpPost]
        public Task<IActionResult> CreateOrder([FromBody] CreateOrderCommand command)
            => Create(command);

        [HttpPut]
        public Task<IActionResult> AddLine([FromBody] AddLineToOrderCommand command)
            => Edit(command);
        #endregion

        #region Queries

        [HttpGet]
        public Task<IActionResult> GetAll([FromQuery] GetAllOrdersQuery command)
            => Query<GetAllOrdersQuery, List<GetAllOrdersQueryResult>>(command);
        #endregion
    }
}
