using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Core.RequestResponse.Orders.QueryResults
{
    public class GetAllOrdersQueryResult
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string CustomerName { get; set; }

        public List<OrderLineDTO> OrderLines { get; set; }
    }
}
