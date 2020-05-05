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
        public int ClientId { get; set; }
        public List<OrderDetailCreateDto> Dishes { get; set; }
        public DateTime DeliveredAt { get; set; }
        public int RestaurantId { get; set; }
    }

    public class OrderDetailCreateDto
    {
        public int DishId { get; set; }
        public List<DishExtraCreateDto> Extras { get; set; }
    }

    public class DishExtraCreateDto
    {
        public int ExtraId { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderUpdateDto
    {
        public string State { get; set; }
    }

    public class OrderStateDto
    {
        public string State { get; set; }
    }
            
    public class OrderDto
    {
        public int OrderId { get; set; }
        public string ClientName { get; set; }
        public List<OrderDetailDto> Dishes { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime DeliveredAt { get; set; }
        public RestaurantDto Restaurant { get; set; }
        public decimal Total { get; set; }
        public string State { get; set; }
    }
}
