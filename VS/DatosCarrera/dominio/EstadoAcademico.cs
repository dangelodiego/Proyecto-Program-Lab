using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    public class EstadoAcademico 
    {
        public Materia Materia {get; set; }

        public Alumno Alumno { get; set; }

        public bool Inscripto { get; set; }

        public int Asistencias { get; set; }

        public int Año { get; set; }
    }
}
