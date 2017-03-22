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
            try
            {
                using (var dataEmpresa = new EmpresaRepository())
                {
                    Empresas = dataEmpresa.ListarEmpresas(); // Llenamos el combo.
                }
            }
            catch (Exception ex)
            {
                MensajeRespuesta = ex.Message;
            }
        }

        public bool Autenticar()
        {
            try
            {
                using (var dataUsuarios = new UsuariosRepository())
                {
                    var result = dataUsuarios.ComprobarUsuario(Usuario, Clave, IdEmpresaSeleccionada);

                    MensajeRespuesta = result ? "Login Exitoso!" : "Error en el Usuario o Clave";

                    return result;
                }
            }
            catch (Exception ex)
            {
                MensajeRespuesta = ex.Message;
            }

            // Si llega aqui es por algun error.
            return false;
        }
    }
}
