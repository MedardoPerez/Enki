using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ENKI.SOFT.Models.DTOs;
using ENKI.SOFT.Models.AppService;
using System;
using System.Linq;

namespace ENKI.SOFT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        public readonly IUsuarioAppService _usuarioAppService;
        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            if(usuarioAppService == null) throw new ArgumentNullException("UsuarioAppService");

            _usuarioAppService = usuarioAppService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<UsuarioDTO>> Get()
        {
            return _usuarioAppService.ObtenerUsuarios().ToList();
        }
    }
}