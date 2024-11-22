using System.ComponentModel.DataAnnotations.Schema;

namespace gameApiApp.Models
{
    [Table("game_genre")]

    public class GameGenre
    {
        [Column("game_id")]

        public int GameId { get; set; }
        [Column("genre_id")]
        public int GenreId { get; set; }
        public Game Game { get; set; }
        public Genre Genre { get; set; }

    }
}