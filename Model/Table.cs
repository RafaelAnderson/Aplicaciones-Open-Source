using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Model
{
    public class Table
    {
        public int TableId { get; set; }
        public int Tablenumber { get; set; }
        public bool avaliable { get; set; }
        List<Reservation> Reservations { get; set; }
    }
}
