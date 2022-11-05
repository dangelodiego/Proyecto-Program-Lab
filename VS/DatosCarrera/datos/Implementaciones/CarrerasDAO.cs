using DatosCarrera.datos.DTOs;
using DatosCarrera.datos.Interfaces;
using DatosCarrera.dominio;
using DatosCarrera.dominio.auxiliares;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DatosCarrera.dominio.auxiliares.Sexo;

namespace DatosCarrera.datos.Implementaciones
{
    public class CarrerasDAO : ICarrerasDAO, IConsultasComplejas
    {

        public int ObtenerProximoId()
        {
            string sp = "SP_PROXIMO_ID";
            return DBHelper.ObtenerInstancia().ConsultaEscalarSQL("SP_PROXIMO_ID", "@next");
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
                cmd.Parameters.AddWithValue("@turno", mesaExamen.Turno.Id);
                cmd.Parameters.AddWithValue("@id_materia", mesaExamen.Materia.Id);
                cmd.Parameters.AddWithValue("@id_profesores", mesaExamen.Profesor.Id);


                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id_materia";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);




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


        public bool BajaLogicaMesa(MesaExamen mesa)
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
                cmd.CommandText = "SP_BAJA_LOGICA_MESA";  ///este SP debería cambiar el campo Activo del maestro a falso y hacer un DELETE FROM examenes WHERE id_mesa=@id_mesa
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_mesa", mesa.Id);
                cmd.ExecuteNonQuery();
                SqlCommand cmdDetalle;
                foreach(Examen examen in mesa.Examenes)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_mesa", mesa.Id);
                    cmdDetalle.Parameters.AddWithValue("@legajo", examen.Alumno.Legajo);
                    cmdDetalle.Parameters.AddWithValue("@nota", examen.Nota);
                    cmdDetalle.ExecuteNonQuery();

                }

                t.Commit();



            }
            catch (Exception)
            {

                if (t != null)
                    t.Rollback();
                ok = false; ;
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








        

  






       

        public List<Materia> GetMateriaAll()
        {
            string sp = "SP_CONSULTAR_MATERIAS";
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


        /**
         * 
         * CONSULTAS COMPLEJAS PARA MOSTRAR EN LABORATORIO
         */




        //CONSULTA 1
        public List<MateriaNotasSuperiorDTO> ObtenerMateriasSegunPromedio(int promedio)
        {
            string sp = "SP_MATERIAS_SEGUN_PROMEDIO";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@promedio", promedio));
            DataTable tabla= DBHelper.ObtenerInstancia().ConsultaSQL(sp);
            List<MateriaNotasSuperiorDTO> listDTO = new List<MateriaNotasSuperiorDTO>();
            foreach(DataRow r in tabla.Rows)
            {
                MateriaNotasSuperiorDTO dto = new MateriaNotasSuperiorDTO();
                dto.IdMateria = Convert.ToInt32(r["id_materia"]);
                dto.NombreMateria = Convert.ToString(r["nombre"]);
                dto.Promedio = Convert.ToDouble(r["promedio"]);
                listDTO.Add(dto);

                
            }
            return listDTO;
        }

        //CONSULTA 2

        public List<AlumnoInfoBasicaDTO> ObtenerAlumnosSegunMateriasCursadas(int cantidad)
        {
            string sp = "SP_CONSULTAR_ALUMNOS_SEGUN_MATERIAS_CURSADAS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@cantidad", cantidad));
            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lst);
            List<AlumnoInfoBasicaDTO> listDTO = new List<AlumnoInfoBasicaDTO>();
            foreach(DataRow r in tabla.Rows)
            {
                AlumnoInfoBasicaDTO dto = new AlumnoInfoBasicaDTO();
                dto.Legajo = Convert.ToInt32(r["legajo"]);
                dto.Alumno = Convert.ToString(r["Alumno"]);
                dto.Dni = Convert.ToInt32(r["documento"]);
                dto.FechaInscripcion = Convert.ToDateTime(r["fecha de inscripcion"]);
                listDTO.Add(dto);


            }
            return listDTO;

        }








        //CONSULTA 3
        public List<AlumnosSegunPromedio_AnioIngresoDTO> ObtenerAlumnos(int anioIngreso1, int anioIngreso2)
        {
            string sp = "SP_ALUMNOS_SEGUN_PROMEDIO_ANIOS_INGRESO";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@anioIngreso1", anioIngreso1));
            lst.Add(new Parametro("@anioIngreso2", anioIngreso2));
            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lst);
            List<AlumnosSegunPromedio_AnioIngresoDTO> listDTO = new List<AlumnosSegunPromedio_AnioIngresoDTO>();
            foreach(DataRow r in tabla.Rows)
            {
                AlumnosSegunPromedio_AnioIngresoDTO dto = new AlumnosSegunPromedio_AnioIngresoDTO();
                dto.Legajo = Convert.ToInt32(r["Legajo"]);
                dto.Alumno = Convert.ToString(r["Nombre Alumno"]);
                dto.Observaciones = Convert.ToString(r["Observaciones"]);


                listDTO.Add(dto);


            }

            return listDTO;
        }



        //CONSULTA 4
        public List<EdadPromedioXCursoDTO> ObtenerPromedioEdadPorCurso()
        {
           
            string sp = "SP_OBTENER_PROMEDIO_EDAD_CURSO";
            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp);
            List<EdadPromedioXCursoDTO> listDTO = new List<EdadPromedioXCursoDTO>();
            foreach (DataRow r in tabla.Rows)
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

        //CONSULTA 5
        public List<MateriaPorcentajeAlumnosDTO> PorcentajeAlumnosNotaMenorPorMateria(int limite)
        {
            
            string sp = "SP_MATERIAS_PORCENTAJE_ALUMNOS_NOTAS_MENOR";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@limite", limite));
            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lst);
            List<MateriaPorcentajeAlumnosDTO> listDTO = new List<MateriaPorcentajeAlumnosDTO>();
            foreach (DataRow r in tabla.Rows)
            {
                MateriaPorcentajeAlumnosDTO dto = new MateriaPorcentajeAlumnosDTO();
                if (r["nombre"] != DBNull.Value)
                    dto.NombreMateria = Convert.ToString(r["nombre"]);
                if (r["porcentaje"]!=DBNull.Value)
                    dto.PorcentajeAlumnos = Convert.ToDouble(r["porcentaje"]);
                listDTO.Add(dto);
            }
            return listDTO;

        }


        //CONSULTA 6
        public List<Profesor> ConsultarProfesoresProntaJubilacion(int aniosParaJubilarse)
        {
            string sp = "SP_PROFESORES_PRONTA_JUBILACION_SEGUN_ANIOS_RESTANTES";
            List<Profesor> list = new List<Profesor>();
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@aniosParaJubilarse", aniosParaJubilarse));

            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lst);
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






        //CONSULTA 7

        public List<AlumnosPromedioMayorPorMateriaDTO> ObtenerAlumnos(double promedio)
        {
            string sp = "SP_ALUMNOS_PROMEDIO_MAYOR_POR_MATERIA";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@promedio", promedio));
            List < AlumnosPromedioMayorPorMateriaDTO> listDTO = new List<AlumnosPromedioMayorPorMateriaDTO>();
            DataTable dt = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lst);
            foreach(DataRow r in dt.Rows)
            {
                AlumnosPromedioMayorPorMateriaDTO dto = new AlumnosPromedioMayorPorMateriaDTO();
                dto.NombreMateria = Convert.ToString(r["Materia"]);
                dto.Alumno = Convert.ToString(r["Alumno"]);
                listDTO.Add(dto);

            }
            return listDTO;



        }

    
       

      

   
   
        //CONSULTAS  8
      public List<AlumnoDesertor> ObtenerAlumnosDesertores(int cantidad)
        {
            string sp = "SP_NO_VAN_A_RENDIR_HACE_TANTOS_AÑOS";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@cantidad", cantidad));
            List<AlumnoDesertor> listDTO = new List<AlumnoDesertor>();
            DataTable dt = DBHelper.ObtenerInstancia().ConsultaSQL(sp);
            foreach(DataRow r in dt.Rows)
            {
                AlumnoDesertor a = new AlumnoDesertor();
                a.Legajo = Convert.ToInt32(r["legajo"]);
                a.NombreCompleto = Convert.ToString(r["nombre_completo"]);
                listDTO.Add(a);

            }

            return listDTO;
        }



        ///METODOS AUXILIARES///


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
                int sexo = int.Parse(row["sexo"].ToString());




                Persona aux = new Persona(id, nombre, apellido, fechaNacimiento, dni, email, telefono);

                lst.Add(aux);

            }

            return lst;

        }


























    }
}
