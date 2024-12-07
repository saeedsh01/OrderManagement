using OrderManagement.Core.Contracts.Orders.Commands;
using OrderManagement.Core.RequestResponse.Orders.Commands.AddLine;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Domain.Exceptions;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace OrderManagement.Core.ApplicationService.Orders.Commands.AddLine
{
    public class AddLineToOrderCommandHandler : CommandHandler<AddLineToOrderCommand>
    {
        private readonly IOrderCommandRepository _orderCommandRepository;
        public AddLineToOrderCommandHandler(ZaminServices zaminServices, IOrderCommandRepository orderCommandRepository) : base(zaminServices)
        {
            _orderCommandRepository = orderCommandRepository;
        }

        public override async Task<CommandResult> Handle(AddLineToOrderCommand command)
        {
            var order = await _orderCommandRepository.GetAsync(command.OrderBusinessId);

            if (order is null)
                throw new InvalidEntityStateException("Order Not Found");

            order.AddLine(productName: command.ProductName, count: command.Count, price: command.price);

            await _orderCommandRepository.CommitAsync();

            return Ok();
        }
    }
}
