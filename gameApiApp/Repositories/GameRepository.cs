using gameApiApp.Data;
using gameApiApp.Interfaces;
using gameApiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace gameApiApp.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly DataContext _context;
        public GameRepository(DataContext context)
        {
            this._context = context;
        }

        public ICollection<GameDto> getGames()
        {
            return _context.game.Include(g => g.Genre).Select(game => new GameDto
            {
                GameId = game.GameId,
                Name = game.Name,
                Price = game.Price,
                GenreName = game.Genre.Name,
            }).OrderBy(game=>game.GameId).ToList();
        }
    }
}
