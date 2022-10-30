using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCarrera.dominio.auxiliares;

namespace DatosCarrera.dominio
{
    public class Curso
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public Turno Turno { get; set; }
    
        public DateTime añoIngreso { get; set; }
    
    
    }
}
