using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    internal class Persona
    {


        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int Dni { get; set; }

        public string Email { get; set; }
        
        public int Telefono { get; set; }

        public Persona(int id, string nombre, string apellido, DateTime fechaNacimiento, int dni, string email, int telefono)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Dni = dni;
            Email = email;
            Telefono = telefono;
        }
    }
}
