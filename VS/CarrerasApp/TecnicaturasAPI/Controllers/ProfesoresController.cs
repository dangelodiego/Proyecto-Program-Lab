using DatosCarrera.facade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TecnicaturasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesoresController : ControllerBase
    {
        private IDatos datos;
        public ProfesoresController()
        {
            datos = new DatosLib();
        }



        [HttpGet("Profesores/{id}")]
        public IActionResult GetProfesoresPorMateria(int id)
        {
            if (datos.GetProfesoresPorMateria(id) != null)
            {
                return Ok(datos.GetProfesoresPorMateria(id));
            }
            else
            {
                return NotFound();
            }
        }


    }

}
