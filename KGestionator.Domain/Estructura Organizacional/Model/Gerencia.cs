using System.Collections.Generic;

namespace KGestionator.Domain.Estructura_Organizacional
{
    public class Gerencia
    {
        public int IdGerencia { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public List<Departamento> Departamentos { get; set; }

        public Gerencia(int idGerencia, string descripcion, string estado)
        {
            IdGerencia = idGerencia;
            Descripcion = descripcion;
            Estado = estado;
            Departamentos = new List<Departamento>();
        }
    }
}
