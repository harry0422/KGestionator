using System.Collections.Generic;

namespace KGestionator.Domain.Seguridad.Model
{
    public class Usuario
    {
        private const string ESTADO_BAJA = "BAJA";
        public Usuario(string correo, string nombre, string contraseña, string idEmpleado)
        {
            Correo = correo;
            Nombre = nombre;
            Contraseña = contraseña;
            IdEmpleado = idEmpleado;
        }

        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string IdEmpleado { get; set; }
        public string Estado { get; set; }
        public List<Rol> Roles { get; set; }

        public void DarDeBaja()
        {
            Estado = ESTADO_BAJA;
        }
    }
}