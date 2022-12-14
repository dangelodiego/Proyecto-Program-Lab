using DatosCarrera.datos.Implementaciones;
using DatosCarrera.datos.Interfaces;
using DatosCarrera.dominio;
using DatosCarrera.dominio.auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.facade
{
    public class DatosLib:IDatos
    {
        private ICarrerasDAO dao;
        private ISoporteDAO soporteDAO;
        private IMesasExamenDAO mesaExamenDAO;
        private IAlumnosDAO alumnosDAO;
        private IProfesoresDAO profesoresDAO;

        public DatosLib()
        {
            dao = new CarrerasDAO();
            soporteDAO = new CarrerasDAO();
            mesaExamenDAO = new CarrerasDAO();
            alumnosDAO = new CarrerasDAO();
            profesoresDAO = new CarrerasDAO();
        }



        public bool SaveMesaExamen(MesaExamen mesaExamen)
        {
            return mesaExamenDAO.CrearMesa(mesaExamen);
        }


        public List<Barrio> GetBarriosaLL()
        {
            return soporteDAO.ObtenerBarrios();
        }

        public List<Ciudad> GetCiudadxProvincia(int id)
        {
            return soporteDAO.ObtenerCiudadxProvincia(id);
        }
        public List<Provincia> GetProvinciasAll()
        {
            return soporteDAO.ObtenerProvincias();
        }
        
        public List<Materia> GetMateriaAll()
        {
            return dao.GetMateriaAll();
        }

        public List<EstadosCiviles> GetEstadosCivilesAll()
        {
            return soporteDAO.ObtenerEstadosCiviles();
        }

        public bool InsertAlumno(Alumno alumno)
        {
            return alumnosDAO.InsertarAlumno(alumno);
        }

        public bool UpdateAlumno(Alumno alumno)
        {
            return alumnosDAO.ActualizarAlumno(alumno);
        }

        public bool DeleteAlumno(Alumno alumno)
        {
            return alumnosDAO.BorrarAlumno(alumno);
        }

        public List<Alumno> GetAlumnosAll()
        {
            return alumnosDAO.GetAlumnosAll();
        }

        public List<Carrera> GetTecnicaturasAll()
        {
            return soporteDAO.ObtenerTecnicaturas();


        }

        public List<Curso> GetCursosAll()
        {
            return soporteDAO.ObtenerCursos();
        }


        public List<Barrio> GetBarriosXCiudad(int id)
        {
            return soporteDAO.ObtenerBarriosXCiudad(id);
        }

        public List<Laboralidades> GetLaboralidadesAll()
        {
            return soporteDAO.ObtenerLaboralidades();
        }

        public List<Habitacionalidades> GetHabitacionalidadesAll()
        {
            return soporteDAO.ObtenerHabitacionalidades();
        }

        public List<Profesor> GetProfesoresPorMateria(int id)
        {
            return profesoresDAO.GetProfesoresPorMateria(id);
        }

        public List<Materia> GetMateriasPorCarrera(int id)
        {
            return soporteDAO.ObtenerMateriasXCarrera(id);
        }
    }
    
}
