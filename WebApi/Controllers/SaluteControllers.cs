using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route ("saludos")]
    [ApiController]

    public class SaluteControllers:ControllerBase
    {
        [HttpGet("{nombre}")]
        public ActionResult<string> ObtainSalute(string nombre)
        {
            return $"Hello fellow Maxwell fan named {nombre}";
        }

    }
}
