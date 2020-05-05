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
    public class ExtraServiceImpl : IExtraService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ExtraServiceImpl(ApplicationDbContext context,
            IMapper mapper
        )
        {
            _context = context;
            _mapper = mapper;
        }

        public DataCollection<ExtraDto> GetAll(int page, int take)
        {
            return _mapper.Map<DataCollection<ExtraDto>>(
                _context.Extras.OrderBy(x => x.ExtraId)
                .AsQueryable()
                .Paged(page, take)
                );
        }
    }
}
