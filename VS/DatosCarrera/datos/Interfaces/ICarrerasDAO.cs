using DatosCarrera.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosCarrera.datos.Interfaces
{
    public interface ICarrerasDAO
    {
        int CantidadAlumnos();
        int CantidadAlumnosRegulares();
        int CantidadAlumnosPromocionados();
        int CantidadAlumnosLibres();
        int CantidadProfesores();
        int CantidadTecnicaturas();






        int ObtenerProximoId();

     


        public List<Materia> GetMateriaAll();









    }
}
