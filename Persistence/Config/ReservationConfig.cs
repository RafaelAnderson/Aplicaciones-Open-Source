using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class ReservationConfig
    {
        public ReservationConfig(EntityTypeBuilder<Reservation>EntityBuilder)
        {
            EntityBuilder.Property(X => X.Table).IsRequired();
            EntityBuilder.Property(X => X.State).IsRequired().HasMaxLength(20);
        }
    }
}
