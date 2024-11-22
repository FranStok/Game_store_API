using gameApiApp.Data;
using gameApiApp.DTOs;
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
            return _context.Games.Select(game => new GameDto
            {
                GameId = game.GameId,
                Name = game.Name,
                image=game.image,
                GameGenres=game.GameGenres.Select(gameGenre=>new GameGenreDTO
                {
                    genre= new GenreDTO {genre=gameGenre.Genre.genre_name, genreId= gameGenre.Genre.GenreId}
                }).ToList(),
                GameStores = game.GameStores.Select(i => new GameStoreDTO { storeId = i.StoreId, price = i.price }).ToList()
            }).OrderBy(game=>game.GameId).ToList();
        }
    }
}
