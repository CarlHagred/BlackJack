using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesLib.DB
{
    public class GameDbContext : DbContext
    {
        public DbSet<Round> Rounds { get; set; }

        public DbSet<PlayerRound> PlayerRounds { get; set; }
    }
}
