using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class DishExtraDto
    {
        public int DishExtraId { get; set; }
        public ExtraDto Extra { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
    }
}
