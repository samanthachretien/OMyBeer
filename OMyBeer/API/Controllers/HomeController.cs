using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("All")]
        public IActionResult Home()
        {
            return Ok("toto");
        }

        [HttpGet]
        [Route("Test/{nom}")]
        public IActionResult Test(string nom)
        {
            try
            {
                return Ok("Bonjour " + nom);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] BeerModel beer)
        {
            return Ok("beer create");
        }
    }
}
