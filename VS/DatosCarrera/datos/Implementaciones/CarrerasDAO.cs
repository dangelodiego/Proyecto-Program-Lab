using DatosCarrera.datos.DTOs;
using DatosCarrera.datos.Interfaces;
using DatosCarrera.dominio;
using DatosCarrera.dominio.auxiliares;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DatosCarrera.dominio.auxiliares.Sexo;

namespace DatosCarrera.datos.Implementaciones
{
    public class CarrerasDAO : ICarrerasDAO, IConsultasComplejas
    {

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


        public bool BorrarAlumno(Alumno alumno)
        {
            string sp = "SP_BORRAR_ALUMNO";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@legajo", alumno.Legajo));
            int afectadas = DBHelper.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;

        }


        public List<Alumno> GetAlumnosAll()
        {
            string sp = "SP_CONSULTAR_ALUMNOS";
            List<Alumno> list = new List<Alumno>();
            DataTable table= DBHelper.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow r in table.Rows)
            {
                Alumno a = new Alumno();

                a.Legajo = Convert.ToInt32(r["legajo"]);
                if (r["nombre"] != DBNull.Value)
                  a.Nombre  = Convert.ToString(r["nombre"]);
                if (r["apellido"] != DBNull.Value)
                    a.Apellido = Convert.ToString(r["apellido"]);
                if (r["fecha_nac"] != DBNull.Value)
                    a.FechaNacimiento = Convert.ToDateTime(r["fecha_nac"]);
                if (r["dni"] != DBNull.Value)
                    a.Dni = Convert.ToInt32(r["dni"]);
                if (r["e_mail"] != DBNull.Value)
                    a.Email = Convert.ToString(r["e_mail"]);
                if (r["telefono"] != DBNull.Value)
                    a.Telefono = Convert.ToInt32(r["telefono"]);
                if (r["calle"] != DBNull.Value)
                    a.Calle = Convert.ToString(r["calle"]);
                if (r["altura"] != DBNull.Value)
                    a.Altura = Convert.ToInt32(r["altura"]);
                if (r["sexo"] != DBNull.Value)
                    a.Sexo = (Sexo)(r["sexo"]);
                if (r["id_curso"] != DBNull.Value)
                    a.Curso.Id = Convert.ToInt32(r["id_curso"]);
                if (r["id_carrera"] != DBNull.Value)
                    a.Carrera.Id = Convert.ToInt32(r["carrera"]);
                if (r["fecha_insc"] != DBNull.Value)
                    a.FechaInscripcion = Convert.ToDateTime(r["fecha_insc"]);
                if (r["id_laboralidad"] != DBNull.Value)
                    a.Laboralidad = (Laboralidades)r["id_laboralidad"];
                if (r["id_habitacionalidad"] != DBNull.Value)
                    a.Habitacionalidad = (Habitacionalidades)r["id_habitacionalidad"];
                if (r["id_barrio"] != DBNull.Value)
                    a.Barrio = (Barrio)r["id_barrio"];

                list.Add(a);

            }
            return list;





        }








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

        public bool BorrarMesa(int nro)
        {
            string sp = "SP_ELIMINAR_MESA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@id_mesa", nro));
            int afectadas = DBHelper.ObtenerInstancia().EjecutarSQL(sp, lst);
            return afectadas > 0;
        }





        public List<Profesor> ConsultarProfesores(int aniosParaJubilarse)
        {
            string sp = "SP_PROFESORES_PRONTA_JUBILACION_SEGUN_ANIOS_RESTANTES";
            List<Profesor> list = new List<Profesor>();
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@aniosParaJubilarse", aniosParaJubilarse));

            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow r in tabla.Rows)
            {
                Profesor p = new Profesor();
                p.Id = Convert.ToInt32(r["id_profesores"]);
                if (r["id_materia"] != DBNull.Value)
                    p.Materia.Id = Convert.ToInt32(r["id_materia"]);
                if (r["nombre"] != DBNull.Value)
                    p.Nombre = Convert.ToString(r["nombre"]);
                if (r["apellido"] != DBNull.Value)
                    p.Apellido = Convert.ToString(r["apellido"]);
                if (r["fecha_nac"] != DBNull.Value)
                    p.FechaNacimiento = Convert.ToDateTime(r["fecha_nac"]);
                if (r["dni"] != DBNull.Value)
                    p.Dni = Convert.ToInt32(r["dni"]);
                if (r["e_mail"] != DBNull.Value)
                    p.Email = Convert.ToString(r["dni"]);
                if (r["telefono"] != DBNull.Value)
                    p.Telefono = Convert.ToInt32(r["telefono"]);
                if (r["calle"] != DBNull.Value)
                    p.Calle = Convert.ToString(r["calle"]); ///cambiar calle y altura directamente por campo domicilio en la BD
                if (r["altura"] != DBNull.Value)
                    p.Altura = Convert.ToInt32(r["altura"]);


                if (r["sexo"] != DBNull.Value)
                    p.Sexo = (Sexo)r["sexo"];

                list.Add(p);
            }
            return list;




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

     
        public List<Alumno> ObtenerAlumnos(int anioIngreso1, int anioIngreso2)
        {
            throw new NotImplementedException();
        }

        public List<AlumnosPromedioMayorPorMateriaDTO> ObtenerAlumnos(double promedio)
        {
            throw new NotImplementedException();
        }

        public List<Materia> ObtenerMateriasSegunPromedio(int promedio)
        {
            throw new NotImplementedException();
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

        public List<EdadPromedioXCursoDTO> ObtenerPromedioEdadPorCurso()
        {
            List<EdadPromedioXCursoDTO> listDTO = new List<EdadPromedioXCursoDTO>();
            string sp = "SP_OBTENER_PROMEDIO_EDAD_CURSO";
            DataTable dt = DBHelper.ObtenerInstancia().ConsultaSQL(sp);
            foreach (DataRow r in dt)
            {
                EdadPromedioXCursoDTO dto = new EdadPromedioXCursoDTO();

                if (r["curso"] != DBNull.Value)
                    dto.NombreCurso = Convert.ToString(r["curso"]);
                if (r["promedio"] != DBNull.Value)
                    dto.PromedioEdad = Convert.ToDouble(r["promedio"]);

                listDTO.Add(dto);

            }

            return listDTO;

        }

        public int ObtenerProximoId()
        {
            string sp = "SP_PROXIMO_ID";
            return DBHelper.ObtenerInstancia().ConsultaEscalarSQL("SP_PROXIMO_ID", "@next");
        }

        public List<MateriaPorcentajeAlumnosDTO> PorcentajeAlumnosNotaMenorPorMateria(int limite)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> ObtenerAlumnos(int cantidad)
        {
            throw new NotImplementedException();
        }
    }
}
