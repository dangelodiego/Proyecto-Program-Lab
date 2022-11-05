using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosCarrera.dominio.auxiliares;

namespace DatosCarrera.dominio
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Provincias Provincia { get; set; }
    }
}
