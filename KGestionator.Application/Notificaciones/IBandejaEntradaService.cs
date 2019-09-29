using KGestionator.Application.Notificaciones.DTOs;

namespace KGestionator.Application.Notificaciones
{
    public interface IBandejaEntradaService
    {
        void ObtenerBandeja(UsuarioDto dto);
    }
}