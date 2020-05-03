using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int TableId { get; set; }
        public Table Table { get; set; }

        public DateTime RegisteredAt { get; set; }
        public DateTime ReservedFor { get; set; }
        public string State { get; set; }
    }
}
