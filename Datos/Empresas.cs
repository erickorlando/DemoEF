namespace Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresas()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(11)]
        public string Ruc { get; set; }

        [Required]
        [StringLength(250)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(500)]
        public string Direccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
