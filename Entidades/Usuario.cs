using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades
{
    public class Usuario : EntidadBase
    {
        public int IdEmpresa { get; set; }

        [ForeignKey(nameof(IdEmpresa))]
        public Empresa Empresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        public string NombresCompletos => $"{Nombres} {Apellidos}";

        [Required]
        [StringLength(20)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }
    }

}
