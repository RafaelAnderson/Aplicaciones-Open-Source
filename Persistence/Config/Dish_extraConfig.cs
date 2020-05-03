using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class Dish_extraConfig
    {
        public Dish_extraConfig(EntityTypeBuilder<Dish_extra> entityBuilder)
        {

            entityBuilder.Property(x => x.Quantity).IsRequired();
            entityBuilder.Property(x => x.SubTotal).IsRequired().HasColumnType("decimal(5,2)");
        }
    }
}
