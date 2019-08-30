using System.Collections.Generic;

namespace KGestionator.Application.Seguridad.DTOs
{
    public class UsuarioAutenticadoDto
    {
        public string Nombre { get; set; }
        public List<RolDto> Roles { get; set; }
    }
}