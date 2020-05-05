using Microsoft.AspNetCore.Mvc;
using PointFood.Dto;
using PointFood.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointFood.Controllers
{
    [ApiController]
    [Route("cards")]
    public class CardController : ControllerBase
    {
        private readonly ICardService _cardService;

        public CardController(ICardService cardService)
        {
            _cardService = cardService;
        }

        [HttpPost]
        public ActionResult Create(CardCreateDto card)
        {
            var result = _cardService.Create(card);

            return CreatedAtAction("GetById", new { id = result.CardId}, result);
        }

        [HttpGet("{id}")]
        public ActionResult<CardDto> GetById(int id)
        {
            return _cardService.GetById(id);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, CardUpdateDto model)
        {
            _cardService.Update(id, model);
            return Ok();
        }


        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            _cardService.Remove(id);
            return Ok();
        }
    }
}
