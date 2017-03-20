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

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DemoBaseDatosInitializer());
        }
    }
}
