using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class EmpresaRepository : IDisposable
    {
        private readonly DemoBaseDatos _contexto;

        public EmpresaRepository()
        {
            _contexto = new DemoBaseDatos();
        }

        public List<Empresa> ListarEmpresas()
        {
            return _contexto.Empresas.AsNoTracking().ToList();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _contexto?.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}