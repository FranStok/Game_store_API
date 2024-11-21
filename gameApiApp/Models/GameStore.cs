using System.ComponentModel.DataAnnotations.Schema;

namespace gameApiApp.Models
{
    [Table("game_price")]

    public class GameStore
    {
        [Column("game_id")]

        public int GameId { get; set; }
        [Column("store_id")]
        public int StoreId { get; set; }
        public Game Game { get; set; }
        public Store Store { get; set; }
        public double price { get; set; }

    }
}
