using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    internal class Examen
    {
        public int Id { get; set; }
       public Alumno Alumno { get; set; }

        public int Nota { get; set; }



    }
}
