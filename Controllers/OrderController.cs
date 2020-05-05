using Microsoft.AspNetCore.Mvc;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public ActionResult Create(OrderCreateDto order)
        {
            var result = _orderService.Create(order);

            return CreatedAtAction("GetById", new { id = result.OrderId }, result);
        }

        [HttpGet("{id}")]
        public ActionResult<OrderDto> GetById(int id)
        {
            return _orderService.GetById(id);
        }

        [HttpGet]
        public ActionResult<DataCollection<OrderDto>> GetAll(int page, int take)
        {
            return _orderService.GetAll(page, take);
        }

        [HttpGet("state")]
        public ActionResult<DataCollection<OrderDto>> GetByState(OrderStateDto model, int page, int take)
        {
            return _orderService.GetByState(model, page, take);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, OrderUpdateDto model)
        {
            _orderService.Update(id, model);
            return Ok();
        }
    }
}
