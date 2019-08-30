namespace KGestionator.Domain.Planillas.Model
{
    public class BoletaPago
    {
        public Empleado Empleado { get; set; }
        public int DiasLaborados { get; set; }
        public int HorasExtras { get; set; }
        public double SueldoBruto { get; set; }
        public double Deducciones { get; set; }
        public double SueldoNeto { get; set; }
        public Bono Bono { get; set; }
        public string Estado { get; set; }

        public BoletaPago(Empleado empleado, int diasLaborados, int cantidadHorasExtras, double sueldoBruto, double deducciones,Bono bono)
        {
            Empleado = empleado;
            DiasLaborados = diasLaborados;
            HorasExtras = cantidadHorasExtras;
            SueldoBruto = sueldoBruto;
            Deducciones = deducciones;
            SueldoNeto = SueldoBruto - Deducciones;
            Bono = bono;
        }
    }
}
