using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appangularCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace appangularCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(new
            {
                Nombre = "Charly",
                Apellido = "Perez",
                Email = "prueba@netcore.com"
            });
        }


        [HttpPost("adduser")]
        public ActionResult Adduser([FromBody] UserViewModel user)
        {
            return Ok();
            
        }

        


    }
}
