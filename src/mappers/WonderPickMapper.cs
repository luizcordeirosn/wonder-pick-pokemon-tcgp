using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wonder_pick_pokemon_tcgp.src.dtos;
using wonder_pick_pokemon_tcgp.src.entities;

namespace wonder_pick_pokemon_tcgp.src.mappers
{
    public class WonderPickMapper
    {
        
        public static WonderPick createDtoToEntity(CreateWonderPickDto dto){
            return new WonderPick(dto.posicaoInicial, dto.posicaoFinal);
        }
    }
}