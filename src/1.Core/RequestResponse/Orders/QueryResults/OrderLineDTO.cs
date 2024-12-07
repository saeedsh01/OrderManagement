namespace OrderManagement.Core.RequestResponse.Orders.QueryResults
{
    public class OrderLineDTO
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public int Count { get; set; }
        public decimal price { get; set; }
        public string ProductName { get; set; }
    }
}
