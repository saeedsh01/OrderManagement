namespace OrderManagement.Infra.Data.Sql.Queries.Orders.Entity
{
    public class OrderLine
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }

    }
}
