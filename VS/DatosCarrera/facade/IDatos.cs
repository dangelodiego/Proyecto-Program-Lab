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
        public List<Persona> GetPersonasAll();
        public bool SaveMesaExamen(MesaExamen mesaExamen);








    }
}
