using DatosCarrera.datos.Implementaciones;
using DatosCarrera.datos.Interfaces;
using DatosCarrera.dominio;
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

        public DatosLib(ICarrerasDAO dao)
        {
            this.dao = dao;
        }

       

        public bool SaveMesaExamen(MesaExamen mesaExamen)
        {
            return dao.CrearMesa(mesaExamen);
        }


        public List<Barrio> GetBarriosaLL()
        {
            return dao.ObtenerBarrios();
        }

        public List<Ciudad> GetCiudadesAll()
        {
            return dao.ObtenerCiudades();
        }
        public List<Provincia> GetProvinciasAll()
        {
            return dao.ObtenerProvincias();
        }

        public List<Materia> GetMateriaAll()
        {
            return dao.GetMateriaAll();
        }

      













    }
}
