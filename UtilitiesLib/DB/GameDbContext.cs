using Microsoft.EntityFrameworkCore;


namespace UtilitiesLib.DB
{
    public class GameDbContext : DbContext
    {
        public DbSet<Round> Rounds { get; set; }
        public DbSet<PlayerRound> PlayerRounds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Gamedb");
    }
}
