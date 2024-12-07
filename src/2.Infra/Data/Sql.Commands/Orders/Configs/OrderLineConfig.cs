using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrderManagement.Core.Domain.Orders.Entities;

namespace OrderManagement.Infra.Data.Sql.Commands.Orders.Configs
{
    public class OrderLineConfig : IEntityTypeConfiguration<OrderLine>
    {
        public void Configure(EntityTypeBuilder<OrderLine> builder)
        {
            builder.Property(s => s.ProductName).HasMaxLength(180);
        }
    }
}
