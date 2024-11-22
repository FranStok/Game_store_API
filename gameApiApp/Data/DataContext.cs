using gameApiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace gameApiApp.Data
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameStore>()
                .HasKey(gs => new { gs.GameId, gs.StoreId });
            modelBuilder.Entity<GameStore>()
                .HasOne(gs => gs.Game)
                .WithMany(g => g.GameStores)
                .HasForeignKey(gs => gs.GameId);
            modelBuilder.Entity<GameStore>()
                .HasOne(gs => gs.Store)
                .WithMany(c => c.GameStores)
                .HasForeignKey(gs => gs.StoreId);

            modelBuilder.Entity<GameGenre>()
                .HasKey(gs => new { gs.GameId, gs.GenreId });
            modelBuilder.Entity<GameGenre>()
                .HasOne(gs => gs.Game)
                .WithMany(g => g.GameGenres)
                .HasForeignKey(gs => gs.GameId);
            modelBuilder.Entity<GameGenre>()
                .HasOne(gs => gs.Genre)
                .WithMany(c => c.GameGenres)
                .HasForeignKey(gs => gs.GenreId);
        }
    }
}
