using System.ComponentModel.DataAnnotations.Schema;

namespace gameApiApp.Models
{
    [Table("genre")]

    public class Genre
    {
        [Column("genre_id")]
        public int GenreId { get; set; }
        
        [Column("ganre_name")]
        public string genre_name { get; set; }
        public required ICollection<GameGenre> GameGenres { get; set; }

    }
}
