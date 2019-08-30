using KGestionator.Application.Seguridad.DTOs;

namespace KGestionator.Application.Seguridad
{
    public interface ISeguridadService
    {
        UsuarioAutenticadoDto Autenticar(CredencialesDto dto);
        bool AgregarUsuario(UsuarioDto dto);

        bool ModificarUsuario(UsuarioDto dto);

        bool DarBaja(UsuarioDeBajaDto dto);

        UsuarioDto ConsultarUsuario(UsuarioDeConsultaDto dto);


    }
}