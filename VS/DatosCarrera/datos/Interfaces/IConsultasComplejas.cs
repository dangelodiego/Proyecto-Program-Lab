using DatosCarrera.datos.DTOs;
using DatosCarrera.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Interfaces
{
    public interface IConsultasComplejas
    {
        List<Materia> ObtenerMateriasSegunPromedio(int promedio);
        List<Alumno> ObtenerAlumnos(int cantidad); //sirve para consultas 2 y 8

        List<Alumno> ObtenerAlumnos(int anioIngreso1, int anioIngreso2);

        List<EdadPromedioXCursoDTO> ObtenerPromedioEdadPorCurso();

        List<MateriaPorcentajeAlumnosDTO> PorcentajeAlumnosNotaMenorPorMateria(int limite);

        List<Profesor> ConsultarProfesores(int aniosParaJubilarse);

        List<AlumnosPromedioMayorPorMateriaDTO> ObtenerAlumnos(double promedio);


    }
}
