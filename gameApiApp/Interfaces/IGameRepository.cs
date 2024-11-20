using gameApiApp.Models;

namespace gameApiApp.Interfaces
{
    public interface IGameRepository
    {
        ICollection<GameDto> getGames();
    }
}
