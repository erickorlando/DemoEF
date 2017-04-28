namespace Datos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DemoBaseDatosModel : DbContext
    {
        public DemoBaseDatosModel()
            : base("name=CodeFirstDBExistente")
        {
        }

        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empresas>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Empresas)
                .HasForeignKey(e => e.IdEmpresa);

            //modelBuilder.Entity<Usuarios>()
            //    .Property(p => p.Clave)
            //    .HasMaxLength(30)
            //    .IsRequired();
        }
    }
}
