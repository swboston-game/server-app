using System.Data.Entity;

namespace WhoIzIt.Model
{
    public class WhoIzItDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Invite> Invites { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
    }
}
