using API.Data;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class BeerController : Controller
    {
        private BeerService _beerService;

        public BeerController(BeerService beerService)
        {
            _beerService = beerService;
        }


        [HttpPost]
        [Route("Ajout")]
        public IActionResult Ajout([FromBody] TBeer beer)
        {
            bool ajout = _beerService.AjouterBeer(beer);
            return Ok(ajout);
        }

        [HttpGet]
        [Route("Afficher/{id}")]
        public IActionResult Afficher(int id)
        {
            return Ok(_beerService.Search(id));
        }
    }
}
