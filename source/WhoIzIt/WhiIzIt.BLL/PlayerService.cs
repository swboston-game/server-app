using System.Linq;
using WhoIzIt.Model;

namespace WhiIzIt.BLL
{
    public class PlayerService
    {
        readonly WhoIzItDbContext _context = new WhoIzItDbContext();

        public void CreatePlayer(string email, string displayName, string faceBookId)
        {
            var player = new Player();
            player.DisplayName = displayName;
            player.Email = email;
            player.FaceBookId = faceBookId;
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public void Won(int playerId)
        {
            var player = _context.Players.Single(p => p.Id == playerId);
            player.Wins += 1;
            player.Streak += 1;
            _context.SaveChanges();
        }

        public void Lost(int playerId)
        {
            var player = _context.Players.Single(p => p.Id == playerId);
            player.Loses += 1;
            player.Streak = 0;
            _context.SaveChanges();
        }
    }
}
