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

        public DatosLib()
        {
            dao = new CarrerasDAO();
            soporteDAO = new CarrerasDAO();
            mesaExamenDAO = new CarrerasDAO();
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
    }
    
}
