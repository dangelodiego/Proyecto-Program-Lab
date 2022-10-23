using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    public class Alumno { 
        public int Legajo { get; set; }

        public Persona Persona { get; set; }

        public Curso Curso { get; set; }

        public Carrera Carrera { get; set; }

        public DateTime FechaInscripcion { get; set; }

    

      
    }
}
