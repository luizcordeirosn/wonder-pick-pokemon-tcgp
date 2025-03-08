using wonder_pick_pokemon_tcgp.src.entities;

namespace wonder_pick_pokemon_tcgp.src.repositories
{
    public interface IWonderPickRepository
    {
        Task<WonderPick> AddAsync(WonderPick wp);
        Task<WonderPick> GetByIdAsync(Guid id);
        Task<List<WonderPick>> GetLastSevenByPosicaoInicialAsync(int posicaoInicial);
    }
}