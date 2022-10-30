using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCarrera.dominio.auxiliares;

namespace DatosCarrera.dominio
{
    public class Evaluacion
    {
        public int Id { get; set; }
        public Alumno Alumno { get; set; }
        public Materia Materia { get; set; }

        public int Nota { get; set; }

        public TipoEvaluacion Tipo { get; set; }

        public DateTime Fecha { get; set; }

        public Profesor Profesor { get; set; }



    }
}
