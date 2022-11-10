using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.DTOs
{
    public class DatosAlumnosDTO
    {
        public int Legajo { get; set; }
        public string NombreAlumno { get; set; }
        public string Laboralidad { get; set; }
        public string Habitacionalidad { get; set; }
        public decimal Nota { get; set; }
    }
}
