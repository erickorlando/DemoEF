using System.Collections.Generic;
using Datos;
using Entidades;

namespace LogicaNegocio
{
    public class UsuariosViewModel
    {
        public List<UsuarioInfo> ListaUsuarios { get; set; }

        public void CargarLista()
        {
            using (var data = new UsuariosRepository())
            {
                ListaUsuarios = data.ListarUsuariosPorEmpresa();
            }
        }
    }
}