namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        public int Id { get; set; }

        public int IdEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(20)]
        public string NombreUsuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        public virtual Empresas Empresas { get; set; }
    }
}
