using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameApp.WebRole.Models {
    public class GameContext : DbContext {

        public DbSet<Game> Games { get; set; }
        public DbSet<CannedAnswer> CannedAnswers { get; set; }
        public DbSet<GameInvite> GameInvites { get; set; }
        public DbSet<GameMove> GameMoves { get; set; }
        public DbSet<User> Users { get; set; }

    }
}