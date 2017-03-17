using System.Linq;

namespace Datos
{
    public class UsuariosRepository
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
    }
}
