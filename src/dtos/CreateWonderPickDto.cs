using System.ComponentModel.DataAnnotations;

namespace wonder_pick_pokemon_tcgp.src.dtos
{
    public class CreateWonderPickDto
    {
        [Required]
        public int posicaoInicial { get; set; }
        
        [Required]
        public int posicaoFinal { get; set; }
    }
}