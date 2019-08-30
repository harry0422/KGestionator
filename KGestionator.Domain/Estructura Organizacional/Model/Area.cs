namespace KGestionator.Domain.Estructura_Organizacional
{
    public class Area
    {
        public int IdArea { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Area(int idArea, string descripcion, string estado)
        {
            IdArea = idArea;
            Descripcion = descripcion;
            Estado = estado;
        }
    }
}
