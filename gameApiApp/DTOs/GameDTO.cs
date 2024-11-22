using gameApiApp.DTOs;
using gameApiApp.Models;

public class GameDto
{
    public int GameId { get; set; }
    public string Name { get; set; }

    public ICollection<GameStoreDTO> GameStores { get; set; }
    public ICollection<GameGenreDTO> GameGenres { get; set; }
}