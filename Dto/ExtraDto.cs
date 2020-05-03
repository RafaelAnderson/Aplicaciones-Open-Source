using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class ExtraDto
    {
        public int ExtraId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class ExtraCreateDto
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class ExtraUpdateDto
    {
        [Required]
        public int Name { get; set; }
        public int Quantity { get; set; }
    }
}
