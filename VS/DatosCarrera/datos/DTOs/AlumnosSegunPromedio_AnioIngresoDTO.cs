using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.DTOs
{
    public class AlumnosSegunPromedio_AnioIngresoDTO
    {
        /*
        3)--Mostrar en una misma tabla de resultados los
        alumnos que ingresaron este año con promedio de 8
        o mas
        --y los alumnos que ingresaron el año pasado con
        promedio de 8 o más. Ordenados de forma alfabética
        por nombre
        --de alumno.
         */

        public int Legajo { get; set; }
        public string Alumno { get; set; }
        public string Observaciones { get; set; }




    }
}
