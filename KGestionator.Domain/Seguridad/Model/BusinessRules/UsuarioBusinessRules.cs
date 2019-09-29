using KGestionator.Domain.Commons;

namespace KGestionator.Domain.Seguridad.Model.BusinessRules
{
    public static class UsuarioBusinessRules
    {
        public static BusinessRule CorreoVacio
        {
            get { return new BusinessRule("Correo", "Correo no puede ir vacio."); }
        }

        public static BusinessRule ContraseñaNoValida
        {
            get { return new BusinessRule("Contraseña", "La Contraseña no es valida"); }
        }

    }
}