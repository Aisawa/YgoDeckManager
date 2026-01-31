using Microsoft.AspNetCore.Mvc;
using YgoDeckManager.Services;

namespace YgoDeckManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CardsController : ControllerBase
    {
        private readonly YgoApiService _service;
        public CardsController(YgoApiService service) => _service = service;

        [HttpGet("sets")]
        public async Task<IActionResult> GetSets() => Ok(await _service.GetSetsAsync());

        [HttpGet("set/{setName}")]
        public async Task<IActionResult> GetCards(string setName) => Ok(await _service.GetCardsBySetAsync(setName));
    }
}
