using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class ClientDto
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class ClientCreateDto
    {
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class ClientUpdateDto
    {
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}
