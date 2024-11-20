namespace gameApiApp.Models
{
    public class Game
    {
        public int GameId { get; set; }
        public required String Name { get; set; }
        public double Price { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }

    }
}
