using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ENKI.SOFT.Models.DTOs;

namespace ENKI.SOFT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<UsuarioDTO>> Get()
        {
            return new List<UsuarioDTO>();
        }
    }
}