using System;

namespace KGestionator.Application.Logs
{
    public interface ILogsAdapter
    {
        void GuardarMensaje(string mensaje);

        void GuardarError(string mensaje, Exception exception);
    }
}