using System;
using System.Collections.Generic;
using System.Linq;
using WhoIzIt.Model;

namespace WhiIzIt.BLL
{
    public class GamePiecesService
    {
        private readonly WhoIzItDbContext _context = new WhoIzItDbContext();
        public ICollection<GamePiece> GenerateGamePieces(int challengerId, int opponentId)
        {
            var challenger = _context.Players.Single(p => p.Id == challengerId);
            var opponent = _context.Players.Single(p => p.Id == opponentId);
            var challengerFacebookFriends = GetFaceBrookFriends(challenger.FaceBookId).ToList();
            var opponentFaceBookFriends = GetFaceBrookFriends(opponent.FaceBookId).ToList();
            challengerFacebookFriends.AddRange(opponentFaceBookFriends);
            var friends = challengerFacebookFriends.Distinct();
            var gamePieces = friends.Select(friend => new GamePiece
                                                          {
                                                              Id = _context.GamePieces.Count() + 1,
                                                              ImageUrl = GetImageUrlFromFaceBook(friend)
                                                          }).ToList();
            if (gamePieces.Count < 15)
            {
                var howManyNeeded = 15 - gamePieces.Count;
                gamePieces.AddRange(GetRandomGamePieces(howManyNeeded));
            }
            return gamePieces;
        }

        private IEnumerable<GamePiece> GetRandomGamePieces(int howManyNeeded)
        {
            var stockPieces = _context.StockGamePieces.ToList();
            var pieces = new List<GamePiece>();
            for (var i = 0; i < howManyNeeded; i++)
            {
                var random = new Random();
                var randomNumber = random.Next(0, stockPieces.Count);
                var gamePiece = stockPieces[randomNumber];
                pieces.Add(gamePiece);
                stockPieces.RemoveAt(randomNumber);
            }
            return pieces;
        }

        private string GetImageUrlFromFaceBook(string friend)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<string> GetFaceBrookFriends(string faceBookId)
        {
            throw new NotImplementedException();
        }
    }
}
