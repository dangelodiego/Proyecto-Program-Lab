using DatosCarrera.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Interfaces
{
    public interface ICarrerasDAO
    {
         List<Provincia> ObtenerProvincias();

         List<Ciudad> ObtenerCiudades();

         List<Barrio> ObtenerBarrios();








        int ObtenerProximoId();

        bool CrearMesa(MesaExamen mesaExamen);

        bool RectificarMesa(MesaExamen mesaExamen);

      

        MesaExamen ObtenerMesasPorId(int id);


        public List<Materia> GetMateriaAll();









    }
}
