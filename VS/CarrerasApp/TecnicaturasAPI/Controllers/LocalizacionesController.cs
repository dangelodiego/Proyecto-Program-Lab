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
        public IActionResult Get()
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

        // POST api/<LocalizacionesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            
        }

        // PUT api/<LocalizacionesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocalizacionesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
