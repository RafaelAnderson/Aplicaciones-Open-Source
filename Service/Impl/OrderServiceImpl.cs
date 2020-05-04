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
            CalculateSubTotalDisExtra(entry.Dishes);
            CalculateSubtotalOrderDetail(entry.Dishes);
            entry.Total = entry.Dishes.Sum(x => x.SubTotal);
            entry.State = "Pendiente";

            _context.Add(entry);
            _context.SaveChanges();

            return _mapper.Map<OrderDto>(entry);
        }

        public void CalculateSubTotalDisExtra(IEnumerable<OrderDetail> dishes)
        {
            foreach(var dish in dishes)
            {
                foreach(var extra in dish.Dish.Extras)
                {
                    extra.SubTotal = extra.Extra.Price * extra.Quantity;
                }
            }
        }

        public void CalculateSubtotalOrderDetail(IEnumerable<OrderDetail> dishes)
        {
            foreach(var dish in dishes)
            {
                dish.SubTotal = dish.Dish.Extras.Sum(x => x.SubTotal) + dish.Dish.Price;        
            }
        }

        public DataCollection<OrderDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<OrderDto>>(
                _context.Orders.OrderBy(x => x.OrderId)
                .Include(x => x.Client)
                .Include(x => x.Dishes)
                    .ThenInclude(x => x.Dish)
                        .ThenInclude(x => x.Extras)
                            .ThenInclude(x => x.Extra)
                .Include(x => x.Restaurant)
                    .ThenInclude(x => x.RestaurantOwner)
                .AsQueryable()
                .Paged(page, take)
                );
        }

        public DataCollection<OrderDto> GetAllByClientId(int id)
        {
            return _mapper.Map<DataCollection<OrderDto>>(
                _context.Orders.OrderBy(x => x.OrderId)
                .Include(x => x.Client)
                .Include(x => x.Dishes)
                    .ThenInclude(x => x.Dish)
                        .ThenInclude(x => x.Extras)
                            .ThenInclude(x => x.Extra)
                .Include(x => x.Restaurant)
                    .ThenInclude(x => x.RestaurantOwner)
                .All(x => x.ClientId == id)
                );
        }

        public void Update(int id, string state)
        {
            var entry = _context.Orders.Single(x => x.OrderId == id);
            entry.State = state;

            _context.SaveChanges();
        }
    }
}
