using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    public class Materia
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public bool Promocionable { get; set; }

        public Carrera Carrera { get; set; }

    }
}
