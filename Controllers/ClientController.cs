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
    [Route("clients")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPost]
        public ActionResult Create(ClientCreateDto client)
        {
            var result = _clientService.Create(client);

            return CreatedAtAction("GetById", new { id = result.ClientId }, result);
        }

        [HttpGet("{id}")]
        public ActionResult<ClientDto> GetById(int id)
        {
            return _clientService.GetById(id);
        }

        [HttpGet]
        public ActionResult<DataCollection<ClientDto>> GetAll(int page, int take)
        {
            return _clientService.GetAll(page, take);
        }

        [HttpGet("login")]
        public ActionResult<ClientDto> GetByUsernameAndPassword(ClientLoginDto model)
        {
            return _clientService.GetByUsernameAndPassword(model);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, ClientUpdateDto model)
        {
            _clientService.Update(id, model);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            _clientService.Remove(id);
            return Ok();
        }
    }
}
