using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.DTOs
{
    public class MateriaNotasSuperiorDTO
    {
        /*

        1)--Listar todas las materias de todas las
        carreras/cursos que tengan promedio de nota
        superior a 5---

         */



        public int IdMateria { get; set; }
        public string NombreMateria { get; set; }
        public double Promedio { get; set; }

    }
}
