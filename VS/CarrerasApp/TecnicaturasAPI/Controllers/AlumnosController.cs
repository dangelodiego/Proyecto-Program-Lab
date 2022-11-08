using DatosCarrera.dominio;
using DatosCarrera.facade;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TecnicaturasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        private IDatos _datos;


        public AlumnosController()
        {
            _datos = new DatosLib();
        }

        [HttpPost]
        public IActionResult Post(Alumno alumno)
        {
            if (alumno == null)
            {
                return BadRequest();
            }
            if (_datos.InsertAlumno(alumno))
            {
                return Ok("Se inserto exitosamente el alumno");
            }
            else
            {
                return BadRequest("Los datos no se insertaron debido a falta o error en los datos");
            }
            
        }

        [HttpGet("Laboralidad")]

        public IActionResult GetLaboralidad()
        {
            if (_datos.GetLaboralidadesAll() != null)
            {
                return Ok(_datos.GetLaboralidadesAll());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("Habitacionalidad")]

        public IActionResult GetHabitacionalidad()
        {
            if (_datos.GetHabitacionalidadesAll() != null)
            {
                return Ok(_datos.GetHabitacionalidadesAll());
            }
            else
            {
                return NotFound();
            }
        }





        // GET: api/<AlumnosController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AlumnosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        // PUT api/<AlumnosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlumnosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
