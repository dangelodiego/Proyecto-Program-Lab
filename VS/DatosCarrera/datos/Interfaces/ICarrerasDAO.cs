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
        List<Persona> ObtenerPersonas();
        int ObtenerProximoId();

        bool CrearMesa(MesaExamen mesaExamen);

        bool ActualizarMesa(MesaExamen mesaExamen);

        bool Borrar(int nro);

        MesaExamen ObtenerMesasPorId(int id);


        public List<Materia> GetMateriaAll();









    }
}
