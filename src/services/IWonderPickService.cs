using wonder_pick_pokemon_tcgp.src.dtos;
using wonder_pick_pokemon_tcgp.src.entities;

namespace wonder_pick_pokemon_tcgp.src.services
{
    public interface IWonderPickService
    {
        Task<WonderPick> AddAsync(CreateWonderPickDto dto);
        Task<WonderPick> GetByIdAsync(Guid id);
        Task<List<WonderPick>> GetLastSevenByPosicaoInicialAsync(int posicaoInicial);
    }
}