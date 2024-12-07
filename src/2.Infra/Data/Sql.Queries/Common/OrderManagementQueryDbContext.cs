using Microsoft.EntityFrameworkCore;
using OrderManagement.Core.Domain.Orders.Entities;
using Zamin.Infra.Data.Sql.Queries;

namespace OrderManagement.Infra.Data.Sql.Queries.Common
{
    public class OrderManagementQueryDbContext : BaseQueryDbContext
    {
        public DbSet<Order> orders { get; set; }
        public OrderManagementQueryDbContext(DbContextOptions<OrderManagementQueryDbContext> options) : base(options)
        {
        }
    }
}