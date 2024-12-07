using Zamin.Core.RequestResponse.Commands;

namespace OrderManagement.Core.RequestResponse.Orders.Commands.Create
{
    public class CreateOrderCommand : ICommand
    {
        public string Customer { get; set; }
    }
}
