﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gameApiApp.Models
{
    [Table("games")]
    public class Game
    {
        [Column("game_id")]
        public required int GameId { get; set; }
        [Column("game_name")]
        public required String Name { get; set; }

        public required String image { get; set; }

        public required ICollection<GameGenre> GameGenres { get; set; }

        public required ICollection<GameStore> GameStores { get; set; }
    }
}
