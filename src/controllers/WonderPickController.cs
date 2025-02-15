using Microsoft.AspNetCore.Mvc;
using wonder_pick_pokemon_tcgp.src.dtos;
using wonder_pick_pokemon_tcgp.src.entities;
using wonder_pick_pokemon_tcgp.src.services;

namespace wonder_pick_pokemon_tcgp.src.controllers
{
    [ApiController]
    [Route("wonder-pick")]
    public class WonderPickController : ControllerBase
    {
        private readonly WonderPickService _service;

        public WonderPickController(WonderPickService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateWonderPickDto dto)
        {
            WonderPick createdItem = await _service.AddAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = createdItem.Id }, createdItem);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }
    }
}