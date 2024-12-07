

using OrderManagement.Core.Domain.Orders.Events;
using Zamin.Core.Domain.Entities;

namespace OrderManagement.Core.Domain.Orders.Entities
{
    public class Order : AggregateRoot<long>
    {
        public string CustomerName { get; private set; }
        public DateTime OrderDateTime { get; private set; }
        public List<OrderLine> OrderLines { get; private set; }
        public decimal TotalPrice => OrderLines.Sum(x => x.Price * x.Count);
        public bool HasPayment { get; private set; }

        public Order(string customerName)
        {
            CustomerName = customerName;
            OrderDateTime = DateTime.Now;
            PaymentDone();
        }

        public void AddLine(string productName, int count, decimal price)
        {
            if (OrderLines is null)
                OrderLines = new List<OrderLine>();

            OrderLines.Add(new OrderLine(productName, count, price));
        }

        public void PaymentDone()
        {
            HasPayment = true;

            AddEvent(new OrderPaymentDoneEvent(BusinessId));
        }
    }
}
