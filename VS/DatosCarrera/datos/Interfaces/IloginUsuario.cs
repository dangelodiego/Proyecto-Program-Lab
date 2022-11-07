using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Interfaces
{
    public interface IloginUsuario
    {
        int ChequearLogin(string usuario, string contrasenia);


    }
}
