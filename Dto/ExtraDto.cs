﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class ExtraDto
    {
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ExtrasInfoDto
    {
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
