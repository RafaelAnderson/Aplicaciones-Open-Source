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
        DataCollection<OrderDto> GetByState(OrderStateDto model, int page, int take);
        DataCollection<OrderDto> GetAll(int page, int take);
        OrderDto Create(OrderCreateDto model);
        OrderDto GetById(int id);
        void Update(int id, OrderUpdateDto model);
    }
}
