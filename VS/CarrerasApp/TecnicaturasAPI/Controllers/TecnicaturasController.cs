using DatosCarrera.facade;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TecnicaturasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnicaturasController : ControllerBase
    {
        private IDatos datos;

        public TecnicaturasController()
        {
            datos = new DatosLib();
        }
        
        

        // GET api/<TecnicaturasController>/5
        [HttpGet]
        public IActionResult GetTecnicatura()
        {
            if (datos.GetTecnicaturasAll() != null)
            {
                return Ok(datos.GetTecnicaturasAll());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("Curso")]
        public IActionResult GetCurso()
        {
            if (datos.GetCursosAll() != null)
            {
                return Ok(datos.GetCursosAll());
            }
            else
            {
                return NotFound();
            }
        }



    }
}
