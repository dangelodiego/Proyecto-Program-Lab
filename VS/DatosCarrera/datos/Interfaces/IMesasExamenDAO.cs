using DatosCarrera.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Interfaces
{
    public interface IMesasExamenDAO
    {
        bool CrearMesa(MesaExamen mesa);

  

        bool RectificarMesa(MesaExamen mesa);



        MesaExamen ObtenerMesasPorId(int id);






    }
}
