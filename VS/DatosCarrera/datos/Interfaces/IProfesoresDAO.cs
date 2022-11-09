using DatosCarrera.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Interfaces
{
    public interface IProfesoresDAO
    {
        bool InsertarProfesor(Profesor profesor);

        bool ActualizarProfesor(Profesor profesor);

        bool BorrarProfesor(Profesor profesor);

        List<Profesor> GetProfesoresAll();

        List<Profesor> GetProfesoresPorMateria(int id);




    }
}
