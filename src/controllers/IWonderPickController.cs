using Microsoft.AspNetCore.Mvc;
using wonder_pick_pokemon_tcgp.src.dtos;
using wonder_pick_pokemon_tcgp.src.entities;

namespace wonder_pick_pokemon_tcgp.src.controllers
{
    public interface IWonderPickController
    {
        Task<IActionResult> Create(CreateWonderPickDto dto);
        Task<IActionResult> GetById(Guid id);
        Task<IActionResult> GetLastSevenByPosicaoInicial(int posicaoInicial);
    }
}