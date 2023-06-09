using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerPinReyes.Models
{
    public class Usuario
    {
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public string NombreUsuario { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]

        public string clave { get; set; }
        [Required]

        public Boolean estado { get; set; }
        
        public int GeneroId { get; set; }

        public Genero genero { get; set; }




    }
}
