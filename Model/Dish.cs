using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        List<OrderDetail> orderDetails { get; set; }
        List<Dish_extra> Dish_Extras { get; set; }
    }
}
