using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using System.Data.SqlClient;
=======
using DatosCarrera.dominio;
using Microsoft.Data.SqlClient;
>>>>>>> 60af94e129e0cda72d9896bfb06066f792d1da15



namespace DatosCarrera.datos
{
    internal class DBHelper
    {
        private static DBHelper instancia;
        private SqlConnection cnn;

        private DBHelper()
        {
            cnn = new SqlConnection(@"Data Source=DESKTOP-74QHVRO\SQLEXPRESS;Initial Catalog=TECNICATURAS_FRC_UTN;Integrated Security=True");

        }

        public static DBHelper ObtenerInstancia()
        {
            if(instancia == null)
                instancia = new DBHelper();
            return instancia;
        }

        internal DataTable ConsultaSQL(string spNombre, List<Parametro> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Clave, oParametro.Valor);
                }
            }
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
        }

        internal int ConsultaEscalarSQL(string spNombre, string pOutNombre)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = pOutNombre;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();
            return (int)pOut.Value;
        }


        internal int EjecutarSQL(string strSql, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = strSql;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Clave, param.Valor);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;
        }

        internal SqlConnection ObtenerConexion()
        {
            return this.cnn;
        }


        internal DataTable ConsultaSQL(string spNombre)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
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
                cmd.Parameters.AddWithValue("@turno", mesaExamen.Turno);
                cmd.Parameters.AddWithValue("@id_materia", mesaExamen.Materia.Id);
                cmd.Parameters.AddWithValue("@id_profesores", mesaExamen.Profesor.Id);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id_mesa";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);



                cmd.ExecuteNonQuery();
                int idMesa = Convert.ToInt32(pOut.Value);

                SqlCommand cmdDetalle;

                foreach (Examen item in mesaExamen.Examenes)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@id_mesa", idMesa);
                    cmdDetalle.Parameters.AddWithValue("@legajo", item.Alumno.Legajo);
                    cmdDetalle.Parameters.AddWithValue("@nota", item.Nota);
                    cmdDetalle.ExecuteNonQuery();


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



        public bool RectificarMesa(MesaExamen mesaExamen)
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
                cmd.CommandText = "SP_MODIFICAR_MESA"; ///DELETE FROM examenes WHERE id_mesa=@id_mesa
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha", mesaExamen.Fecha);
                cmd.Parameters.AddWithValue("@turno_examen", mesaExamen.Turno);
                cmd.Parameters.AddWithValue("@id_materia", mesaExamen.Materia.Id);
                cmd.Parameters.AddWithValue("@id_profesores", mesaExamen.Profesor.Id);




                cmd.ExecuteNonQuery();

                SqlCommand cmdDetalle;

                foreach (Examen item in mesaExamen.Examenes)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;

                    cmdDetalle.Parameters.AddWithValue("@id_mesa", mesaExamen.Id);
                    cmdDetalle.Parameters.AddWithValue("@legajo", item.Alumno.Legajo);
                    cmdDetalle.Parameters.AddWithValue("@nota", item.Nota);
                    cmdDetalle.ExecuteNonQuery();


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



        public bool InsertarAlumno(Alumno alumno)
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
                cmd.CommandText = "SP_INSERTAR_ALUMNO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                cmd.Parameters.AddWithValue("@fecha_nac", alumno.FechaNacimiento);
                cmd.Parameters.AddWithValue("@dni", alumno.Dni);
                cmd.Parameters.AddWithValue("@e_mail", alumno.Email);
                cmd.Parameters.AddWithValue("@telefono", alumno.Telefono);
                cmd.Parameters.AddWithValue("@calle", alumno.Calle);
                cmd.Parameters.AddWithValue("@altura", alumno.Altura);
                cmd.Parameters.AddWithValue("@sexo", alumno.Sexo);
                cmd.Parameters.AddWithValue("@id_curso", alumno.Curso.Id);
                cmd.Parameters.AddWithValue("@id_carrera", alumno.Carrera.Id);
                cmd.Parameters.AddWithValue("@fecha_insc", alumno.FechaInscripcion);
                cmd.Parameters.AddWithValue("@id_estado_civil", alumno.EstadoCivil);
                cmd.Parameters.AddWithValue("@id_laboralidad", alumno.Laboralidad);
                cmd.Parameters.AddWithValue("@id_habitacionalidad", alumno.Habitacionalidad);
                cmd.Parameters.AddWithValue("@id_barrio", alumno.Barrio.Id);
                cmd.ExecuteNonQuery();
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




        public bool ActualizarAlumno(Alumno alumno)
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
                cmd.CommandText = "SP_MODIFICAR_ALUMNO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                cmd.Parameters.AddWithValue("@fecha_nac", alumno.FechaNacimiento);
                cmd.Parameters.AddWithValue("@dni", alumno.Dni);
                cmd.Parameters.AddWithValue("@e_mail", alumno.Email);
                cmd.Parameters.AddWithValue("@telefono", alumno.Telefono);
                cmd.Parameters.AddWithValue("@calle", alumno.Calle);
                cmd.Parameters.AddWithValue("@altura", alumno.Altura);
                cmd.Parameters.AddWithValue("@sexo", alumno.Sexo);
                cmd.Parameters.AddWithValue("@id_curso", alumno.Curso.Id);
                cmd.Parameters.AddWithValue("@id_carrera", alumno.Carrera.Id);
                cmd.Parameters.AddWithValue("@fecha_insc", alumno.FechaInscripcion);
                cmd.Parameters.AddWithValue("@id_estado_civil", alumno.EstadoCivil);
                cmd.Parameters.AddWithValue("@id_laboralidad", alumno.Laboralidad);
                cmd.Parameters.AddWithValue("@id_habitacionalidad", alumno.Habitacionalidad);
                cmd.Parameters.AddWithValue("@id_barrio", alumno.Barrio.Id);
                cmd.ExecuteNonQuery();
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


   


        public bool InsertarProfesor(Profesor profesor)
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
                cmd.CommandText = "SP_INSERTAR_PROFESOR";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", profesor.Nombre);
                cmd.Parameters.AddWithValue("@apellido", profesor.Apellido);
                cmd.Parameters.AddWithValue("@fecha_nac", profesor.FechaNacimiento);
                cmd.Parameters.AddWithValue("@dni", profesor.Dni);
                cmd.Parameters.AddWithValue("@e_mail", profesor.Email);
                cmd.Parameters.AddWithValue("@telefono", profesor.Telefono);
                cmd.Parameters.AddWithValue("@calle", profesor.Calle);
                cmd.Parameters.AddWithValue("@altura", profesor.Altura);
                cmd.Parameters.AddWithValue("@sexo", profesor.Sexo);
                cmd.Parameters.AddWithValue("@id_barrio", profesor.Barrio.Id);
                cmd.ExecuteNonQuery();
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

        public bool ActualizarProfesor(Profesor profesor)
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
                cmd.CommandText = "SP_MODIFICAR_PROFESOR";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", profesor.Nombre);
                cmd.Parameters.AddWithValue("@apellido", profesor.Apellido);
                cmd.Parameters.AddWithValue("@fecha_nac", profesor.FechaNacimiento);
                cmd.Parameters.AddWithValue("@dni", profesor.Dni);
                cmd.Parameters.AddWithValue("@e_mail", profesor.Email);
                cmd.Parameters.AddWithValue("@telefono", profesor.Telefono);
                cmd.Parameters.AddWithValue("@calle", profesor.Calle);
                cmd.Parameters.AddWithValue("@altura", profesor.Altura);
                cmd.Parameters.AddWithValue("@sexo", profesor.Sexo);
                cmd.Parameters.AddWithValue("@id_barrio", profesor.Barrio.Id);
                cmd.ExecuteNonQuery();
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














    }
}
