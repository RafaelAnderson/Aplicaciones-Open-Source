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
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public Guid Password { get; set; }
        public List<RestaurantDto> Restaurants { get; set; }
    }
}
