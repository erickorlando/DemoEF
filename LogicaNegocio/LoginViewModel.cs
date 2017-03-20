using System;
using System.Collections.Generic;
using Datos;
using Entidades;

namespace LogicaNegocio
{
    public class LoginViewModel
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public List<Empresa> Empresas { get; set; }
        public int IdEmpresaSeleccionada { get; set; }

        public string MensajeRespuesta { get; set; }

        public LoginViewModel()
        {
            var dataEmpresa = new EmpresaRepository();

            Empresas = dataEmpresa.ListarEmpresas();
        }

        public void Autenticar()
        {
            try
            {
                var dataUsuarios = new UsuariosRepository();

                var result = dataUsuarios.ComprobarUsuario(Usuario, Clave, IdEmpresaSeleccionada);

                MensajeRespuesta = result ? "Login Exitoso!" : "Error en el Usuario o Clave";
            }
            catch (Exception ex)
            {
                MensajeRespuesta = ex.Message;
            }
        }
    }
}
