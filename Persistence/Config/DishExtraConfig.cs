using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class DishExtraConfig
    {
        public DishExtraConfig(EntityTypeBuilder<DishExtra> entityBuilder)
        {
            entityBuilder.HasOne(x => x.Dish)
                .WithMany(x => x.Extras)
                .HasForeignKey(x => x.DishId);

            entityBuilder.HasOne(x => x.Extra)
                .WithMany(x => x.Dishes)
                .HasForeignKey(x => x.ExtraId);

            entityBuilder.Property(x => x.Quantity).IsRequired();
            entityBuilder.Property(x => x.SubTotal).IsRequired().HasColumnType("decimal(5,2)");
        }
    }
}
