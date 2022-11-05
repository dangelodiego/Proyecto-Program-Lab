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
        List<MateriaNotasSuperiorDTO> ObtenerMateriasSegunPromedio(int promedio);

        List<AlumnoInfoBasicaDTO> ObtenerAlumnosSegunMateriasCursadas(int cantidad);


        List<AlumnosSegunPromedio_AnioIngresoDTO> ObtenerAlumnos(int anioIngreso1, int anioIngreso2);

        List<EdadPromedioXCursoDTO> ObtenerPromedioEdadPorCurso();

        List<MateriaPorcentajeAlumnosDTO> PorcentajeAlumnosNotaMenorPorMateria(int limite);

        List<Profesor> ConsultarProfesoresProntaJubilacion(int aniosParaJubilarse);

        List<AlumnosPromedioMayorPorMateriaDTO> ObtenerAlumnos(double promedio);

        List<AlumnoDesertor> ObtenerAlumnosDesertores(int cantidadAnios);


    }
}
