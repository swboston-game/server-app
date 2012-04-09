using System.Linq;
using WhoIzIt.Model;

namespace WhiIzIt.BLL
{
    public class PlayerService
    {
        readonly WhoIzItDbContext _context = new WhoIzItDbContext();

        public void CreatePlayer(string email, string displayName, string faceBookId)
        {
            var player = new Player
            {
                DisplayName = displayName,
                Email = email,
                FaceBookId = faceBookId
            };
            player.TotalPoints += 1000;
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public void Won(int playerId)
        {
            var player = _context.Players.Single(p => p.Id == playerId);
            player.Wins += 1;
            player.Streak += 1;
            player.TotalPoints += 500;
            _context.SaveChanges();
        }

        public void Lost(int playerId)
        {
            var player = _context.Players.Single(p => p.Id == playerId);
            player.Loses += 1;
            player.Streak = 0;
            player.TotalPoints += 100;
            _context.SaveChanges();
        }

        public void IncreasePoints(int playerId, int points)
        {
            var player = _context.Players.Single(p => p.Id == playerId);
            player.TotalPoints += points;
            _context.SaveChanges();
        }
    }
}
