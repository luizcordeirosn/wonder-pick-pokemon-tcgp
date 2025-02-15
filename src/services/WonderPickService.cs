using wonder_pick_pokemon_tcgp.src.dtos;
using wonder_pick_pokemon_tcgp.src.entities;
using wonder_pick_pokemon_tcgp.src.mappers;
using wonder_pick_pokemon_tcgp.src.repositories;

namespace wonder_pick_pokemon_tcgp.src.services
{
    public class WonderPickService
    {
        private readonly WonderPickRepository _repository;

        public WonderPickService(WonderPickRepository repository)
        {
            _repository = repository;
        }

        public async Task<WonderPick> AddAsync(CreateWonderPickDto dto)
        {
            return await _repository.AddAsync(WonderPickMapper.createDtoToEntity(dto));
        }

        public async Task<WonderPick> GetByIdAsync(Guid id)
        {
            WonderPick wp = await _repository.GetByIdAsync(id);

            if(wp == null) {
                throw new KeyNotFoundException($"WonderPick with ID {id} not found.");
            } else {
                return await _repository.GetByIdAsync(id);
            }
        }
    }
}