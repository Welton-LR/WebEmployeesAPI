using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebEmployeesAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        { 
            return Ok("Fala, Welton! Tudo beleza?");
        }
    }

}
