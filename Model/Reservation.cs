using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int TableNumber { get; set; }
        public int Quantity { get; set; }

        public DateTime RegisteredAt { get; set; }
        public DateTime ReservedFor { get; set; }
        public string State { get; set; }
    }
}
