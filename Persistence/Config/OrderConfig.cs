using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class OrderConfig
    {
        public OrderConfig(EntityTypeBuilder<Order> entityBuilder)
        {
            entityBuilder.HasOne(x => x.Client)
                .WithMany()
                .HasForeignKey(x => x.ClientId);

            entityBuilder.HasOne(x => x.Restaurant)
                .WithMany()
                .HasForeignKey(x => x.RestaurantId);

            entityBuilder.Property(x => x.RegisteredAt).IsRequired();
            entityBuilder.Property(x => x.DeliveredAt).IsRequired();
            entityBuilder.Property(x => x.Total).IsRequired().HasColumnType("decimal(6,2)");
            entityBuilder.Property(x => x.State).IsRequired();
        }
    }
}
