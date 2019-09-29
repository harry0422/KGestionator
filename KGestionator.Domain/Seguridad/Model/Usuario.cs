using KGestionator.Domain.Commons;
using KGestionator.Domain.Seguridad.Model.BusinessRules;
using System.Collections.Generic;

namespace KGestionator.Domain.Seguridad.Model
{
    public class Usuario : EntityBase<string>, IAggregateRoot
    {
        private const string ESTADO_BAJA = "BAJA";
        private string _correo;

        public Usuario(string correo, string nombre, string contraseña, string idEmpleado)
        {
            Correo = correo;
            Nombre = nombre;
            Contraseña = contraseña;
            IdEmpleado = idEmpleado;
        }

        public string Correo
        {
            get { return _correo; }
            set
            {
                _correo = value;
                Id = value;
            }
        }

        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string IdEmpleado { get; set; }
        public string Estado { get; set; }
        public List<Rol> Roles { get; set; }

        public void DarDeBaja()
        {
            Estado = ESTADO_BAJA;
        }

        protected override void Validate()
        {
            if (string.IsNullOrEmpty(Correo)) AddBrokenRule(UsuarioBusinessRules.CorreoVacio);
            if (Contraseña.Length < 8 ) AddBrokenRule(UsuarioBusinessRules.ContraseñaNoValida);
        }
    }
}