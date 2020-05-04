using PointFood.Commons;
using PointFood.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service
{
    public interface IOrderService
    {
        DataCollection<OrderDto> GetAllByClientId(int id);
        DataCollection<OrderDto> GetAll(int page, int take);
        OrderDto Create(OrderCreateDto model);
        void Update(int id, string state);
    }
}
