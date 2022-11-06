using DatosCarrera.dominio;
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







    }
}
