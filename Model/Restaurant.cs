using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int RestauranteOwnerId { get; set; }
        public RestaurantOwner RestaurantOwner { get; set; }

        public List<Order> Orders { get; set; }
    }
}
