namespace Entidades
{
    /// <summary>
    /// Entidad Compleja.
    /// Representa las columnas a mostrar por un SP que hace un SELECT
    /// </summary>
    public class UsuarioInfo
    {
        public int IdUsuario { get; set; }

        public string NombresCompletos { get; set; }

        public string NombreUsuario { get; set; }

        public string Ruc { get; set; }

        public string RazonSocial { get; set; }
    }
}