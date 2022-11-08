using DatosCarrera.dominio;
using DatosCarrera.dominio.auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Interfaces
{
    public interface ISoporteDAO
    {
        List<Barrio> ObtenerBarrios();
        List<Ciudad> ObtenerCiudadxProvincia(int id);
        List<Provincia> ObtenerProvincias();

        List<EstadosCiviles> ObtenerEstadosCiviles();

        List<Carrera> ObtenerTecnicaturas();

        List<Curso> ObtenerCursos();

        List<Barrio> ObtenerBarriosXCiudad(int id);


        List<Laboralidades> ObtenerLaboralidades();

        List<Habitacionalidades> ObtenerHabitacionalidades();





    }
}
