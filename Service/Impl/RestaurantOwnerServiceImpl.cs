using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PointFood.Commons;
using PointFood.Dto;
using PointFood.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Service.Impl
{
    public class RestaurantOwnerServiceImpl : IRestaurantOwnerService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public RestaurantOwnerServiceImpl(ApplicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        DataCollection<RestaurantOwnerDto> IRestaurantOwnerService.GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<RestaurantOwnerDto>>(
                _context.RestaurantOwners
                .Include(x => x.Restaurants)
                .OrderBy(x => x.RestaurantOwnerId)
                .AsQueryable()
                .Paged(page, take)
                );
        }
    }
}
