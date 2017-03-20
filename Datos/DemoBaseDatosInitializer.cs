using Entidades;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace Datos
{
    public class DemoBaseDatosInitializer : CreateDatabaseIfNotExists<DemoBaseDatos>
    {
        protected override void Seed(DemoBaseDatos context)
        {
            var empresa01 = new Empresa
            {
                Ruc = "20549202266",
                RazonSocial = "Empresa 01",
                Direccion = "Av. Arequipa 1521"
            };
            context.Empresas.AddOrUpdate(empresa => empresa.Id, empresa01, new Empresa
            {
                Ruc = "20100064673",
                RazonSocial = "Empresa 02",
                Direccion = "Av. Peru 3320"
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
                    Nombres = "Pepe",
                    Apellidos = "Gomez",
                    NombreUsuario = "pepegomez",
                    Clave = "pepegomez$"
                });
        }
    }
}