using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class OrderDetailDto
    {
        public int OrderDetailId { get; set; }
        public DishDto Dish { get; set; }
        public decimal SubTotal { get; set; }
    }
}
