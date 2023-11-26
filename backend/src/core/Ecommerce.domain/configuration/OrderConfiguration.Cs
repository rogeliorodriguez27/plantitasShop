namespace Ecommerce.Domain.Configuration;
using Ecommerce.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.OwnsOne(o => o.OrderAddress, x =>{x.WithOwner();});

        builder.HasMany(o => o.OrderItems).WithOne()
        .OnDelete(DeleteBehavior.Cascade);

        builder.Property(s =>s.Status).HasConversion(
            o => o.ToString(),
            o => (OrderStatus)Enum.Parse(typeof(OrderStatus), o)
        );

    }

    
}