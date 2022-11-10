using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.DTOs
{
    public class MateriaSegunPromedioDTO
    {
        public int IdMateria  { get; set; }
        public string NombreMateria { get; set; }
        public decimal Promedio { get; set; }
    }
}
