using DatosCarrera.dominio;
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

        public List<Ciudad> GetCiudadesAll();

        public List<Barrio> GetBarriosaLL();








    }
}
