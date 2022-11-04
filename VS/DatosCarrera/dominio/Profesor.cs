using DatosCarrera.dominio.auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    public class Profesor
    {
        public int Id { get; set; }

        public Materia Materia { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Dni { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }

        public String Calle { get; set; }

        public int Altura { get; set; }

        public Barrio Barrio { get; set; }
        public Sexo Sexo { get; set; }


    }

}
