using Microsoft.EntityFrameworkCore;
using wonder_pick_pokemon_tcgp.src.data;
using wonder_pick_pokemon_tcgp.src.entities;

namespace wonder_pick_pokemon_tcgp.src.repositories
{
    public class WonderPickRepository: IWonderPickRepository
    {
        private readonly ApplicationDbContext _context;

        public WonderPickRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<WonderPick> AddAsync(WonderPick wp)
        {
            _context.wonderPicks.Add(wp);
            await _context.SaveChangesAsync();
            return wp;
        }

        public async Task<WonderPick> GetByIdAsync(Guid id)
        {
            return await _context.wonderPicks.FindAsync(id);
        }

        public async Task<List<WonderPick>> GetLastSevenByPosicaoInicialAsync(int posicaoInicial)
        {
            return await _context.wonderPicks.Where(wp => wp.PosicaoInicial == posicaoInicial)
            .OrderByDescending(wp => wp.DataCriacao)
            .Take(7)
            .ToListAsync();
        }
    }
}