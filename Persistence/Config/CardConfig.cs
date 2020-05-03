﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Persistence.Config
{
    public class CardConfig
    {
        public CardConfig(EntityTypeBuilder<Card> entityBuilder)
        {
            entityBuilder.Property(x => x.Number).IsRequired().HasMaxLength(16);
            entityBuilder.Property(X => X.ClientId).IsRequired();
        }
    }
}
