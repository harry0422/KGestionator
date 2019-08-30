namespace KGestionator.Domain.Seguridad.Model
{
    public class Rol
    {
        public string IdRol { get; set; }
        public string Descripcion { get; set; }

        public Rol(string idRol, string descripcion)
        {
            IdRol = idRol;
            Descripcion = descripcion;
        }
    }
}
