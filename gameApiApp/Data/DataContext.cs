using gameApiApp.Models;
using Microsoft.EntityFrameworkCore;

namespace gameApiApp.Data
{
    public class DataContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {

        }

        public DbSet<Game> game { get; set; }

        public DbSet<Genre> genre { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuración de la relación uno a muchos
            modelBuilder.Entity<Game>()
                .HasOne(g => g.Genre)        // Un Game tiene un Genre
                .WithMany(ge => ge.Games)    // Un Genre tiene muchos Games
                .HasForeignKey(g => g.GenreId); // Clave foránea en Game
        }
    }
}
