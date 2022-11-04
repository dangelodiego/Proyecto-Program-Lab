using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    public class Barrio
    {

        public int Id { get; set; }
        public string Nombre { get; set; }

        public Ciudad Ciudad {get; set;}

    }
}
