using DatosCarrera.datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace DatosCarrera.datos.Implementaciones
{
    public class LoginDAO:IloginUsuario
    {
       
   
        public int ChequearLogin(string usuario, string contrasenia)
        {
            return DBHelper.ObtenerInstancia().login(usuario, contrasenia);
        }
    }
}
