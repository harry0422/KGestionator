using System;
using System.Collections.Generic;

namespace KGestionator.Domain.Estructura_Organizacional
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
        public DateTime  FechaCreacion { get; set; }
        public string Direccion { get; set; }
        public string Mision { get; set; }
        public string Vision { get; set; }
        public List<Gerencia> Gerencias { get; set; }

        public Empresa(int idEmpresa, string nombre, DateTime fechaCreacion, string direccion, string mision, string vision)
        {
            IdEmpresa = idEmpresa;
            NombreEmpresa = nombre;
            FechaCreacion = fechaCreacion;
            Direccion = direccion;
            Mision = mision;
            Vision = vision;
            Gerencias = new List<Gerencia>();
        }
    }
}
