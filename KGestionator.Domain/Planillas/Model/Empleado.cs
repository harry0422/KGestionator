using KGestionator.Domain.Commons;
using System;

namespace KGestionator.Domain.Planillas.Model
{
    public class Empleado : IAggregateRoot
    {
        public int IdEmpleado { get; set; }
        public string Identidad { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Dirección { get; set; }
        public string Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCese { get; set; }
        public string Puesto { get; set; }

        public Empleado(int idEmpleado, string identidad, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string sexo, string direccion, string estado,DateTime fechaIngreso, DateTime fechaCese, string puesto)
        {
            IdEmpleado = idEmpleado;
            Identidad = identidad;
            PrimerNombre = primerNombre;
            SegundoNombre = segundoNombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            Sexo = sexo;
            Dirección = direccion;
            Estado = estado;
            FechaIngreso = fechaIngreso;
            FechaCese = fechaCese;
            Puesto = puesto;


        }
    }
}
