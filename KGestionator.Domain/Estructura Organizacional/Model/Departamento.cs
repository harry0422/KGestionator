using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGestionator.Domain.Estructura_Organizacional
{
   public class Departamento
    {
        public int IdDepartamento { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public List<Area> Areas { get; set; }

        public Departamento(int idDepartamento, string descripcion, string estado)
        {
            IdDepartamento = idDepartamento;
            Descripcion = descripcion;
            Estado = estado;
            Areas = new List<Area>();
        }
    }
}
