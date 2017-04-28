using Entidades;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Datos
{
    public class DemoBaseDatosInitializer : DropCreateDatabaseIfModelChanges<DemoBaseDatos>
    {
        protected override void Seed(DemoBaseDatos context)
        {
            var empresa01 = new Empresa
            {
                Ruc = "20549202266",
                RazonSocial = "Peru .NET Development",
                Direccion = "Av. Prolongacion Iquitos 1570"
            };
            context.Empresas.AddOrUpdate(empresa => empresa.Id, empresa01, new Empresa
            {
                Ruc = "20100064673",
                RazonSocial = "Microsoft Peru",
                Direccion = "Av. Jorge Basadre 1344"
            });

            context.Usuarios.AddOrUpdate(usuario => usuario.Id,
                new Usuario
                {
                    Empresa = empresa01,
                    Nombres = "Erick",
                    Apellidos = "Orlando",
                    NombreUsuario = "erickorlando",
                    Clave = "12345678"
                },
                new Usuario
                {
                    Empresa = empresa01,
                    Nombres = "Milton",
                    Apellidos = "Baltazar",
                    NombreUsuario = "milton",
                    Clave = "perunet"
                });
        }
    }
}