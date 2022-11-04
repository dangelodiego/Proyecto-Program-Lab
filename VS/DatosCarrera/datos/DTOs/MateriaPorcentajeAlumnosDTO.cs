using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.DTOs
{
    public class MateriaPorcentajeAlumnosDTO
    {

        /*
         5)--Listar las materias y su porcentaje de alumnos
        que tienen notas menores a 6
         * */


        public string NombreMateria { get; set; }
        public int PorcentajeAlumnos { get; set; }
    }
}
