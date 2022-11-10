using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.DTOs
{
    public class AlumnosSegunMateriasCursadasDTO
    {
        public int Legajo { get; set; }

        public string Alumno { get; set; }

        public int DNI { get; set; }

        public DateTime FechaInsc { get; set; }
    }
}
