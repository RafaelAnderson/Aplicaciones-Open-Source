using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Table
    {
        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public bool Avaliable { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
