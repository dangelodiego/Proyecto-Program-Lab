using DatosCarrera.facade;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TecnicaturasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosCivilesController : ControllerBase
    {
        private IDatos datos;

        public EstadosCivilesController()
        {
            datos = new DatosLib();
        }

        // GET: api/<ValuesController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<ValuesController>/5
        [HttpGet]
        public IActionResult GetEstadosCiviles()
        {
            if (datos.GetEstadosCivilesAll() != null)
            {
                return Ok(datos.GetEstadosCivilesAll());
            }
            else
            {
                return NotFound();
            }

        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
