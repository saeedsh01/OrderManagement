using Zamin.Core.Domain.Events;
using Zamin.Core.Domain.ValueObjects;

namespace OrderManagement.Core.Domain.Orders.Events
{
    public record OrderPaymentDoneEvent(BusinessId OrderBusinessId) : IDomainEvent;
}
