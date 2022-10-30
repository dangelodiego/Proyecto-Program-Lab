using Microsoft.AspNetCore.Mvc;
using DatosCarrera;
using DatosCarrera.datos;
using DatosCarrera.facade;
using SimpleInjector.Integration.WebApi;
using DatosCarrera.datos.Interfaces;
using DatosCarrera.datos.Implementaciones;
using DatosCarrera.dominio;

using SimpleInjector;
using SimpleInjector.Lifestyles;
//using System.Web.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICarreras.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnicaturasController : ControllerBase
    {
        private IDatos oFacade;


        public TecnicaturasController(IDatos oFacade)
        {
            this.oFacade = oFacade;
        }
        // GET: api/<TecnicaturasController>
        [HttpGet("ConsultarMaterias")]
        public IActionResult GetMaterias()
        {
            Container container = 
            ICarrerasDAO carreras = container.GetInstance<ICarrerasDAO>();
            List<Materia>lst =carreras.GetMateriaAll();
            return Ok(lst);
        }
        // GET api/<TecnicaturasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TecnicaturasController>
        [HttpPost()]
        public IActionResult GetMaterias(List<Parametro>lst)
        {
            Container container = ConfiguracionDependencia();
            ICarrerasDAO carreras = container.GetInstance<ICarrerasDAO>();
            carreras.GetMateriaAll();
            if (lst == null || lst.Count <= 0)
                return BadRequest("Se requiere parametros");
            return Ok(lst);
        }

        // PUT api/<TecnicaturasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TecnicaturasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


        //static Container ConfiguracionDependencia()
        //{
        //    var container = new Container();

        //    container.Register<ICarrerasDAO, CarrerasDAO>();
        //    container.Register<IDatos, DatosLib>();

        //    container.Verify();

        //    return container;
        //}


        protected void Application_Start()
        {
            // Create the container as usual.
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            //container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);

              container.Register<ICarrerasDAO, CarrerasDAO>();
               container.Register<IDatos, DatosLib>();


            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

            // Here your usual Web API configuration stuff.
        }


    }
}
