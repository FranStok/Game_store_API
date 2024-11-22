using gameApiApp.Interfaces;
using gameApiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace gameApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GenreController(IGameRepository gameRepository)
        {
            this._gameRepository = gameRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<Genre>))]
        public IActionResult getGenres()
        {
            var genres = _gameRepository.getGenres();
            var data = new { genres };
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(data);
        }

    }
}
