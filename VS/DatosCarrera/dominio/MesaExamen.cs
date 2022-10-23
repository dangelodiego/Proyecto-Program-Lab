using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.dominio
{
    public class MesaExamen
    {


        public List<Examen> Examenes { get; set; }

        public int Id { get; set; } 
        public DateTime Fecha { get; set; }
        public Turno Turno{ get; set; }

        public Materia Materia{ get; set; } 

        public Profesor Profesor { get; set; }


        public MesaExamen()
        {
            Examenes = new List<Examen>();
        }

        public void AgregarExamen(Examen examen)
        {
        Examenes.Add(examen);
        
        }

        public void QuitarExamen(int i)
        {
            Examenes.RemoveAt(i);
        }










    }
}
