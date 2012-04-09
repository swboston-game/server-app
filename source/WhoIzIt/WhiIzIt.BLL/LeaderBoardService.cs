using System.Collections.Generic;
using System.Linq;
using WhoIzIt.Model;

namespace WhiIzIt.BLL
{
    public class LeaderBoardService
    {
        private readonly WhoIzItDbContext _context = new WhoIzItDbContext();
        private readonly PlayerService _playersService = new PlayerService();

        public IEnumerable<LeaderBoardView> GetLeaderBoardByPoints(int totalRecords)
        {
            var players = _context.Players.OrderBy(p => p.TotalPoints).Take(totalRecords).ToList();
            return players.Select(player => new LeaderBoardView
                                                {
                                                    DisplayName = player.DisplayName,
                                                    ImageUrl = player.ImageUrl,
                                                    TotalPoints = player.TotalPoints
                                                });
        }
    }
}
