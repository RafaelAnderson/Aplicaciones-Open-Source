using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class RestaurantOwnerDto
    {
        public int RestaurantOwnerId { get; set; }
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
    }

    public class RestaurantOwnerCreateDto
    {
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
    }

    public class RestaurantOwnerUpdateDto
    {
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
    }
}
