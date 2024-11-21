using System.ComponentModel.DataAnnotations.Schema;

namespace gameApiApp.Models
{
    [Table("stores")]

    public class Store
    {
        [Column("store_id")]
        public int StoreId { get; set; }
        public string name { get; set; }

        public ICollection<GameStore> GameStores { get; set; }
    }
}
