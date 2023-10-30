using FIAP.Crosscutting.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FIAP.TechChallenge.Infrastructure.Mappings
{
    public class OrderMap : EntityTypeConfigurationBase<Domain.Entities.Order>
    {
        public override void Configure(EntityTypeBuilder<Domain.Entities.Order> builder)
        {
            builder.Property(x => x.CustomerId)
                .HasColumnName("customer_id");

            builder.Property(x => x.Total)
                .HasColumnName("total")
                .HasColumnType("decimal(8,2)")
                .IsRequired();

            builder.ToTable("orders", "order");

            base.Configure(builder);
        }
    }
}
