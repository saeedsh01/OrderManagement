using Zamin.Core.RequestResponse.Commands;

namespace OrderManagement.Core.RequestResponse.Orders.Commands.AddLine
{
    public class AddLineToOrderCommand : ICommand
    {
        public Guid OrderBusinessId { get; set; }
        public int Count { get; set; }
        public decimal price { get; set; }
        public string ProductName { get; set; }
    }
}
