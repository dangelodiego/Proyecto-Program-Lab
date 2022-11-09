using DatosCarrera.facade;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TecnicaturasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private IDatos datos;
        // GET api/<MateriasController>/5


        public MateriasController()
        {
            datos = new DatosLib();
        }


        [HttpGet("Materias")]
        public IActionResult GetMaterias()
        {
            if (datos.GetMateriaAll() != null)
            {
                return Ok(datos.GetMateriaAll());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("Materias/{id}")]
        public IActionResult GetMateriasPorCarrera(int id)
        {
            if (datos.GetMateriasPorCarrera(id) != null)
            {
                return Ok(datos.GetMateriasPorCarrera(id));
            }
            else
            {
                return NotFound();
            }


        }


        // POST api/<MateriasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MateriasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MateriasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
