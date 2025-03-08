using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wonder_pick_pokemon_tcgp.src.entities
{
    public class WonderPick
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public int PosicaoInicial { get; set; }

        [Required]
        public int PosicaoFinal { get; set; }

        [Required]
        [Column(TypeName = "timestamp without time zone")]
        public DateTime DataCriacao { get; set; } = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);

        public WonderPick(int posicaoInicial, int posicaoFinal) {
            PosicaoInicial = posicaoInicial;
            PosicaoFinal = posicaoFinal;
            DataCriacao = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified);
        }
    }
}