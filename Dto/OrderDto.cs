using PointFood.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Dto
{
    public class OrderCreateDto
    {
        [Required]
        public int ClientId { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime DeliveredAt { get; set; }
        [Required]
        public Restaurant restaurant { get; set; }
        public List<OrderDetailCreateDto> Items { get; set; }
    }

    public class OrderDetailCreateDto
    {
        [Required]
        public int DishId { get; set; }
        public int Quantity { get; set; }

    }

    public class OrderDto
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public Restaurant restaurant { get; set; }
        public decimal Total { get; set; }
        public string State { get; set; }
    }
}
