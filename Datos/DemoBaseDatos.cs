using System.Data.Entity;
using Entidades;

namespace Datos
{
    public class DemoBaseDatos : DbContext
    {
        public DemoBaseDatos() : 
            base("Conexion")
        {

        }

        // Aqui solo se consideran las tablas que debe crear EF Code First.

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DemoBaseDatosInitializer());
        }
    }
}
