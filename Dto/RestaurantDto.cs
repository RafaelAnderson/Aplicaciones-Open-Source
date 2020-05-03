using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class RestaurantDto
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string RestaurantOwnerName { get; set; }
    }

    public class RestaurantCreateDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int RestauranteOwnerId { get; set; }
    }

    public class RestaurantUpdateDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
