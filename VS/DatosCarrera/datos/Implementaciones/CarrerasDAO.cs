using DatosCarrera.datos.Interfaces;
using DatosCarrera.dominio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Implementaciones
{
    public class CarrerasDAO : ICarrerasDAO
    {
        public bool ActualizarMesa(MesaExamen mesaExamen)
        {
            bool ok = true;
            SqlConnection cnn = DBHelper.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_MODIFICAR_MAESTRO";
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@fecha", mesaExamen.Fecha);
                //cmd.Parameters.AddWithValue("@turno", mesaExamen.Turno.Id);
                cmd.Parameters.AddWithValue("@id_materia", mesaExamen.Materia.Id);
                cmd.Parameters.AddWithValue("@id_profesores", mesaExamen.Profesor.Id);




                cmd.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (Examen item in mesaExamen.Examenes)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    
                    cmdDetalle.Parameters.AddWithValue("@id_mesa", mesaExamen.Id);
                    cmdDetalle.Parameters.AddWithValue("@legajo", item.Alumno.Legajo);
                    cmdDetalle.Parameters.AddWithValue("@nota", item.Nota);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
                t.Commit();
            }

            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;






        }

        public bool Borrar(int nro)
        {
            string sp = "SP_ELIMINAR_MESA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@presupuesto_nro", nro));
            int afectadas = DBHelper.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
        }

        public bool CrearMesa(MesaExamen mesaExamen)
        {
            bool ok = true;
            SqlConnection cnn = DBHelper.ObtenerInstancia().ObtenerConexion();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_INSERTAR_MAESTRO";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha", mesaExamen.Fecha);
               // cmd.Parameters.AddWithValue("@turno", mesaExamen.Turno.Id);
                cmd.Parameters.AddWithValue("@id_materia", mesaExamen.Materia.Id);
                cmd.Parameters.AddWithValue("@id_profesores", mesaExamen.Profesor.Id);




                cmd.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (Examen item in mesaExamen.Examenes)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@id_mesa", mesaExamen.Id);
                    cmdDetalle.Parameters.AddWithValue("@legajo", item.Alumno.Legajo);
                    cmdDetalle.Parameters.AddWithValue("@nota", item.Nota);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
                t.Commit();
            }

            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                ok = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;
        }

        public List<Materia> GetMateriaAll()
        {
            string sp = "sp_GetMateriasAll";
            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp);
            List<Materia> lst = new List<Materia>();
            foreach(DataRow r in tabla.Rows)
            {
                Materia m = new Materia();
                m.Id = Convert.ToInt32(r["id_materia"]);
                m.Nombre = r["nombre"].ToString();
                m.Promocionable = Convert.ToBoolean(r["promocionalbe"]);
                lst.Add(m);
            }
            return lst;
        }

        public MesaExamen ObtenerMesasPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> lst = new List<Persona>();

            string sp = "SP_CONSULTAR_PERSONAS";
            DataTable t = DBHelper.ObtenerInstancia().ConsultaSQL(sp, null);

            foreach (DataRow row in t.Rows)
            {
                //Mapear un registro a un objeto del modelo de dominio
             
                bool activo = row["activo"].ToString().Equals("S");


                int id = int.Parse(row["id_persona"].ToString());
                string nombre = row["nombre"].ToString();
                string apellido = row["apellido"].ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(row["fec_nac"].ToString());
                int dni = int.Parse(row["dni"].ToString());
                string email = row["e_mail"].ToString();
                int telefono = int.Parse(row["telefono"].ToString());
                int idCalle = int.Parse(row["id_calle"].ToString());
                int altura = int.Parse(row["altura"].ToString());
                int sexo= int.Parse(row["sexo"].ToString());




                Persona aux = new Persona(id, nombre, apellido, fechaNacimiento, dni, email, telefono);
       
                lst.Add(aux);

            }

            return lst;

        }

        public int ObtenerProximoId()
        {
            string sp = "SP_PROXIMO_ID";
            return DBHelper.ObtenerInstancia().ConsultaEscalarSQL("SP_PROXIMO_ID", "@next");
        }
    }
}
