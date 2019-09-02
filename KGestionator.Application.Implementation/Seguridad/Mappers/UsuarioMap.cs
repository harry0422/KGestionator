using KGestionator.Application.Seguridad.DTOs;
using KGestionator.Domain.Seguridad.Model;

namespace KGestionator.Application.Implementation.Seguridad.Mappers
{
    public static class UsuarioMap
    {
        public static UsuarioDto ToDto(this Usuario usuario)
        {
            //ExtensionMethods
            //this indica que ese parámetro se le va agregar a un objeto de ese tipo

            if (usuario == null) return null;

            UsuarioDto dto = new UsuarioDto
            {
                Contraseña = usuario.Contraseña,
                Correo = usuario.Correo,
                Nombre = usuario.Nombre,
                IdEmpleado = usuario.IdEmpleado
            };

            return dto;
        }
    }
}