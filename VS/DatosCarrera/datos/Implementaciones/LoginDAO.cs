using DatosCarrera.datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Implementaciones
{
    public class LoginDAO:IloginUsuario
    {



   
        public bool ChequearLogin(string usuario, string contrasenia)
        {
            string sp = "select usuario, contrasenia FROM Administradores where usario=@usuario and contrasenia=@contrasenia";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@usuario", usuario));
            lst.Add(new Parametro("@contrasenia", contrasenia));

            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lst);
            
            return tabla.Rows.Count > 0;




        }
    }
}
