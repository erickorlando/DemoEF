using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Datos
{
    public class UsuariosRepository : IDisposable
    {
        private readonly DemoBaseDatos _context;

        public UsuariosRepository()
        {
            _context = new DemoBaseDatos();
        }

        public bool ComprobarUsuario(string user, string pass, int idEmpresa)
        {
            var query = from u in _context.Usuarios
                        where u.NombreUsuario == user && u.Clave == pass
                        && u.IdEmpresa == idEmpresa
                        select u;

            return query.Any();
        }

        public List<UsuarioInfo> ListarUsuariosPorEmpresa()
        {
            try
            {
                var query = _context.Database.SqlQuery<UsuarioInfo>("usp_ListarUsuariosByEmpresa");
                return query.ToList();
            }
            catch (Exception)
            {
                Debug.WriteLine("Ejecutar el archivo de Script 'Procedimiento.sql' en el Servidor de SQL para que se cree el SP");
                throw;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context?.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}