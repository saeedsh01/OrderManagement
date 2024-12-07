namespace OrderManagement.Infra.Data.Sql.Queries.Orders.Entity
{
    public class Order
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDateTime { get; set; }
        public List<OrderLine> OrderLines { get; set; }
        public decimal TotalPrice => OrderLines.Sum(x => x.Price * x.Count);
        public bool HasPayment { get; set; }
    }
}
