using DatosCarrera.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Interfaces
{
    public interface IAlumnosDAO
    {
        bool InsertarAlumno(Alumno alumno);
        bool ActualizarAlumno(Alumno alumno);
        bool BorrarAlumno(Alumno alumno);

        List<Alumno> GetAlumnosAll();










    }
}
