using DatosCarrera.dominio.auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    public class Alumno {
        
        public int Legajo { get; set; }


        public Curso Curso { get; set; }

        public Carrera Carrera { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public EstadosCiviles EstadoCivil { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public int Dni { get; set; }
        public string Email { get; set; }
        public Int64 Telefono { get; set; }

        public string Calle { get; set; }

        public int Altura { get; set; }

        public Sexos Sexo { get; set; }

        public Barrio Barrio { get; set; }

       public Habitacionalidades Habitacionalidad { get; set; }

        public Laboralidades Laboralidad { get; set; }


    }
}
