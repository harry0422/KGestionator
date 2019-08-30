namespace KGestionator.Domain.Planillas.Model
{
    public class Bono
    {
        public int IdRol { get; set; }
        public string Descripcion { get; set; }

        public Bono(int idRol, string descripcion)
        {
            IdRol = idRol;
            Descripcion = descripcion;
        }
    }
}
