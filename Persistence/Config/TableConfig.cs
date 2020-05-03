using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class TableConfig
    {
        public TableConfig(EntityTypeBuilder<Table>EntityBuilder)
        {
            EntityBuilder.Property(X => X.avaliable).IsRequired();
        }
    }
}
