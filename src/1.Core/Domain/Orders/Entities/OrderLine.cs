using Zamin.Core.Domain.Entities;

namespace OrderManagement.Core.Domain.Orders.Entities
{
    public class OrderLine : Entity<long>
    {
        public string ProductName { get; private set; }
        public int Count { get; private set; }
        public decimal Price { get; private set; }

        public OrderLine(string productName, int count, decimal price)
        {
            ProductName = productName;
            Count = count;
            Price = price;
        }
    }
}
