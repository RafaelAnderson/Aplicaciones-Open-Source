using AutoMapper;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class DishServiceImpl : IDishService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public DishServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public DataCollection<DishesInfoDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<DishesInfoDto>>(
                _context.Dishes.OrderByDescending(x => x.DishId)
                .AsQueryable()
                .Paged(page, take)
                );
        }
    }
}
