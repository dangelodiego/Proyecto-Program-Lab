using DatosCarrera.dominio;
using DatosCarrera.facade;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TecnicaturasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesasController : ControllerBase
    {
        private IDatos _datos;
        

        public MesasController()
        {
            _datos = new DatosLib();
        }



        // GET: api/<MesasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MesasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MesasController>
        [HttpPost]
        public IActionResult Post(MesaExamen mesa)
        {
            if (mesa == null)
            {
                return BadRequest();
            }
            if (_datos.SaveMesaExamen(mesa))
            {
                return Ok("Se inserto exitosamente la mesa");
            }
            else
            {
                return BadRequest("Los datos no se insertaron debido a falta o error en los datos");
            }

        }











        // PUT api/<MesasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MesasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
