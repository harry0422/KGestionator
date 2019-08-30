using System;
using System.Collections.Generic;

namespace KGestionator.Domain.Planillas.Model
{
    public class Planilla
    {
        public int IdPlanilla { get; set; }
        public DateTime FechaGeneracion { get; set; }
        public DateTime PeriodoDesde { get; set; }
        public DateTime PeriodoHasta { get; set; }
        public List<BoletaPago> DetallePlanilla{ get; set; }

        public Planilla(int idPlanilla,DateTime fechaGeneracion, DateTime periodoDesde, DateTime periodoHasta, List<BoletaPago> BoletasPlanilla)
        {
            IdPlanilla = idPlanilla;
            FechaGeneracion = fechaGeneracion;
            PeriodoDesde = periodoDesde;
            PeriodoHasta = periodoHasta;
            DetallePlanilla = BoletasPlanilla;
        }
    }
}
