using Microsoft.EntityFrameworkCore;
using OrderManagement.Core.Domain.Orders.Entities;
using System.Reflection;
using Zamin.Extensions.Events.Outbox.Dal.EF;

namespace OrderManagement.Infra.Data.Sql.Commands.Common
{
    public class OrderManagementCommandDbContext : BaseOutboxCommandDbContext
    {
        public DbSet<Order> Orders { get; set; }
        public OrderManagementCommandDbContext(DbContextOptions<OrderManagementCommandDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}