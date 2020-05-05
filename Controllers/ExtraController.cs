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
    [Route("extras")]
    public class ExtraController : ControllerBase
    {
        private readonly IExtraService _extraService;

        public ExtraController(IExtraService extraService)
        {
            _extraService = extraService;
        }

        [HttpGet]
        public ActionResult<DataCollection<ExtraDto>> GetAll(int page, int take)
        {
            return _extraService.GetAll(page, take);
        }
    }
}
