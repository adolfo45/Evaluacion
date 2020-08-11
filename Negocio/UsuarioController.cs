using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Datos.Domains;
using Microsoft.AspNetCore.Mvc;

namespace Negocio
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        #region * Constructor *
        public UsuarioController(UsuarioDomain usuarioDomain)
        {
            _usuarioDomain = usuarioDomain;
        }//public UsuarioController(UsuarioDomain usuarioDomain)
        #endregion

        #region * Variables *
        private readonly UsuarioDomain _usuarioDomain;
        #endregion

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return Ok("Hola");
        }
    }
}