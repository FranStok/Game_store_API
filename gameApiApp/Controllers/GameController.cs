using gameApiApp.Interfaces;
using gameApiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace gameApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GameController(IGameRepository gameRepository)
        {
            this._gameRepository = gameRepository;
        }
        [HttpGet]
        [ProducesResponseType(200,Type = typeof(ICollection<Game>))]
        public IActionResult getGames()
        {
            var games = _gameRepository.getGames();

            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            return Ok(games);
        }

    }
}
