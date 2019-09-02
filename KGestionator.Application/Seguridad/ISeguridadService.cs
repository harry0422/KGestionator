using KGestionator.Application.Seguridad.DTOs;

namespace KGestionator.Application.Seguridad
{
    public interface ISeguridadService
    {
        UsuarioDto Autenticar(CredencialesDto dto);
        void AgregarUsuario(UsuarioDto dto);
        void ModificarUsuario(UsuarioDto dto);
        void DarBaja(UsuarioDeBajaDto dto);
        UsuarioDto ConsultarUsuario(UsuarioDeConsultaDto dto);
    }
}