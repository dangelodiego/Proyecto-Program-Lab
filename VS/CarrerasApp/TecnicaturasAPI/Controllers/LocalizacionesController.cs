using Microsoft.AspNetCore.Mvc;
using DatosCarrera.facade;
using DatosCarrera.dominio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TecnicaturasAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class LocalizacionesController : ControllerBase
    {
        private IDatos _datos;

        public LocalizacionesController()
        {
            _datos = new DatosLib();
        }


        // GET api/<LocalizacionesController>/5
        [HttpGet("Provincias")]
        public IActionResult GetProvincias()
        {
            if (_datos.GetProvinciasAll() != null)
            {
                return Ok(_datos.GetProvinciasAll());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("Ciudades/{id}")]
        public IActionResult GetCiudades(int id)
        {
            if (_datos.GetCiudadxProvincia(id) != null)
            {
                return Ok(_datos.GetCiudadxProvincia(id));
            }
            else
            {
                return NotFound();
            }
        }

        
        

        [HttpGet("Barrios/{id}")]
        public IActionResult GetBarrios(int id)
        {
            if (_datos.GetBarriosXCiudad(id) != null)
            {
                return Ok(_datos.GetBarriosXCiudad(id));
            }
            else
            {
                return NotFound();
            }
            
        }

    }
}
