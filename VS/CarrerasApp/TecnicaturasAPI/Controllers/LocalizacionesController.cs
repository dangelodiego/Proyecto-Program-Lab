﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("Ciudades")]
        public IActionResult GetCiudades()
        {
            if (_datos.GetProvinciasAll() != null)
            {
                return Ok(_datos.GetCiudadesAll());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("Barrios")]
        public IActionResult GetBarrios()
        {
            if (_datos.GetBarriosaLL() != null)
            {
                return Ok(_datos.GetBarriosaLL());
            }
            else
            {
                return NotFound();
            }

        }

    }
}
