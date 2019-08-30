using System.Collections.Generic;

namespace KGestionator.Domain.Seguridad.Model
{
    public class Usuario
    {
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
        public List<Rol> Roles { get; set; }
    }
}