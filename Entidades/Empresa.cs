using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Empresa : EntidadBase
    {
        [Required]
        [StringLength(11)]
        [MinLength(11)]
        public string Ruc { get; set; }

        [Required]
        [StringLength(120)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(500)]
        public string Direccion { get; set; }

        public ICollection<Usuario> Usuarios { get; set; }
    }
}