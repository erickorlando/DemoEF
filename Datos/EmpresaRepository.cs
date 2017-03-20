using System.Collections.Generic;
using System.Linq;
using Entidades;

namespace Datos
{
    public class EmpresaRepository
    {
        private readonly DemoBaseDatos _contexto;

        public EmpresaRepository()
        {
            _contexto = new DemoBaseDatos();    
        }

        public List<Empresa> ListarEmpresas()
        {
            return _contexto.Empresas.ToList();
        }
    }
}
