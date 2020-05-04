using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class TableDto
    {
        public int TableId { get; set; }
        public int TableNumber { get; set; }
        public bool Avaliable { get; set; }
    }

    public class TableCreateDto
    {
        public int TableNumber { get; set; }
        public bool Avaliable { get; set; }
    }

    public class TableUpdateDto
    {
        public int TableNumber { get; set; }
    }
}
