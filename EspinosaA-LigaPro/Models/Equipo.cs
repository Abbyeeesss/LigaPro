using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EspinosaA_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        [Required]
        [MaxLength]
        [DisplayName("Nombre del equipo")]
        public int Id { get; set; }
        [Range(0, 100)]
        public string Nombre { get; set; }
        [Range(0, 100)]
        public int PartidosJugados { get; set; }
        [Range(0, 100)]
        public int PartidosGanados { get; set; }
        [Range(0, 100)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 100)]
        public int PartidosPerdidos { get; set; }
        public int Puntos
        {
            get
            {
                int puntos = PartidosGanados * 3 + PartidosEmpatados;
                return puntos;
            }
        }
    }
}