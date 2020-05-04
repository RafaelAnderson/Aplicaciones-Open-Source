using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class RestaurantOwner
    {
        public int RestaurantOwnerId { get; set; }
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public List<Restaurant> Restaurants { get; set; }
    }
}
