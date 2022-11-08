using DatosCarrera.dominio;
using DatosCarrera.dominio.auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.facade
{
    public interface IDatos
    {
     
        public bool SaveMesaExamen(MesaExamen mesaExamen);

        public List<Materia> GetMateriaAll();

        public List<Provincia> GetProvinciasAll();

        public List<Ciudad> GetCiudadxProvincia(int id);

        public List<Barrio> GetBarriosaLL();

        public List<EstadosCiviles> GetEstadosCivilesAll();

        bool InsertAlumno(Alumno alumno);
        bool UpdateAlumno(Alumno alumno);
        bool DeleteAlumno(Alumno alumno);

        List<Alumno> GetAlumnosAll();

        List<Carrera> GetTecnicaturasAll();

        List<Curso> GetCursosAll();

        List<Barrio> GetBarriosXCiudad(int id);

        List<Laboralidades> GetLaboralidadesAll();

        List<Habitacionalidades> GetHabitacionalidadesAll();












    }
}
