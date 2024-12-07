using OrderManagement.Core.Contracts.Orders.Commands;
using OrderManagement.Core.Domain.Orders.Entities;
using OrderManagement.Core.RequestResponse.Orders.Commands.Create;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.RequestResponse.Commands;
using Zamin.Utilities;

namespace OrderManagement.Core.ApplicationService.Orders.Commands.Create
{
    public class CreateOrderCommandHandler : CommandHandler<CreateOrderCommand>
    {
        private readonly IOrderCommandRepository _orderCommandRepository;
        public CreateOrderCommandHandler(ZaminServices zaminServices,
            IOrderCommandRepository orderCommandRepository) : base(zaminServices)
        {
            _orderCommandRepository = orderCommandRepository;
        }

        public override async Task<CommandResult> Handle(CreateOrderCommand command)
        {
            var order = new Order(command.Customer);

            _orderCommandRepository.Insert(order);

            await _orderCommandRepository.CommitAsync();

            return Ok();
        }
    }
}
