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

        public List<Materia> GetMateriaAll()
        {
            return dao.GetMateriaAll();
        }

        public List<Persona> GetPersonasAll()
        {
            return dao.ObtenerPersonas();
        }

        public bool SaveMesaExamen(MesaExamen mesaExamen)
        {
            return dao.CrearMesa(mesaExamen);
        }

















    }
}
