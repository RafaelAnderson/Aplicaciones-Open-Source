using PointFood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class DishDto
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        List<Dish_extra> Dish_Extras { get; set; }
    }

    public class DishCreateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class DishUpdateDto
    {
        public string Name { get; set; }
    }
}
