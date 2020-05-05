using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Model;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class OrderServiceImpl : IOrderService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public OrderServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public OrderDto Create(OrderCreateDto model)
        {
            var entry = _mapper.Map<Order>(model);
            entry.RegisteredAt = DateTime.Now;
            CalculateSubTotalDishExtra(entry.Dishes);
            CalculateSubtotalOrderDetail(entry.Dishes);
            entry.Total = entry.Dishes.Sum(x => x.SubTotal);
            entry.State = "Pendiente";

            _context.Add(entry);
            _context.SaveChanges();

            return _mapper.Map<OrderDto>(GetById(entry.OrderId));
        }

        public OrderDto GetById(int id)
        {
            return _mapper.Map<OrderDto>(
                _context.Orders
                .Include(x => x.Client)
                .Include(x => x.Restaurant)
                    .ThenInclude(x => x.RestaurantOwner)
                .Include(x => x.Dishes)
                    .ThenInclude(x => x.Extras)
                        .ThenInclude(x => x.Extra)
                .Include(x => x.Dishes)
                    .ThenInclude(x => x.Dish)
                .Single(x => x.OrderId == id));
        }

        public void CalculateSubTotalDishExtra(IEnumerable<OrderDetail> dishes)
        {
            foreach(var dish in dishes)
            {
                foreach(var extra in dish.Extras)
                {
                    extra.SubTotal = _context.Extras.Single(x => x.ExtraId == extra.ExtraId).Price * extra.Quantity;
                }
            }
        }

        public void CalculateSubtotalOrderDetail(IEnumerable<OrderDetail> dishes)
        {
            foreach(var dish in dishes)
            {
                dish.SubTotal = dish.Extras.Sum(x => x.SubTotal) + _context.Dishes.Single(x => x.DishId == dish.DishId).Price;        
            }
        }

        public DataCollection<OrderDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<OrderDto>>(
                _context.Orders.OrderBy(x => x.OrderId)
                .Include(x => x.Client)
                .Include(x => x.Restaurant)
                    .ThenInclude(x => x.RestaurantOwner)
                .Include(x => x.Dishes)
                    .ThenInclude(x => x.Extras)
                        .ThenInclude(x => x.Extra)
                .Include(x => x.Dishes)
                    .ThenInclude(x => x.Dish)
                .AsQueryable()
                .Paged(page, take)
                );
        }


        public void Update(int id, OrderUpdateDto model)
        {
            var entry = _context.Orders.Single(x => x.OrderId == id);
            entry.State = model.State;

            _context.SaveChanges();
        }

        public DataCollection<OrderDto> GetByState(OrderStateDto model, int page, int take)
        {
            return _mapper.Map<DataCollection<OrderDto>>(
                _context.Orders.OrderBy(x => x.OrderId)
                .Include(x => x.Client)
                .Include(x => x.Restaurant)
                .Include(x => x.Dishes)
                    .ThenInclude(x => x.Extras)
                        .ThenInclude(x => x.Extra)
                .Include(x => x.Dishes)
                    .ThenInclude(x => x.Dish)
                .AsQueryable().Where(x => x.State == model.State)
                .Paged(page, take)
                );
        }

    }
}
