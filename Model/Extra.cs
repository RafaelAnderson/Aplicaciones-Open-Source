using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Extra
    {
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public List<Dish_extra> dishDetails { get; set; }
    }
}
