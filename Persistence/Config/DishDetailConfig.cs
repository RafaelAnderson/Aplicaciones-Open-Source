using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class DishDetailConfig
    {
        public DishDetailConfig(EntityTypeBuilder<DishDetail> entityBuilder)
        {
            entityBuilder.HasOne(x => x.OrderDetail)
                .WithMany(x => x.Extras)
                .HasForeignKey(x => x.OrderDetailId);

            entityBuilder.HasOne(x => x.Extra)
                .WithMany()
                .HasForeignKey(x => x.ExtraId);

            entityBuilder.Property(x => x.Quantity).IsRequired();
            entityBuilder.Property(x => x.SubTotal).IsRequired().HasColumnType("decimal(5,2)");
        }
    }
}
