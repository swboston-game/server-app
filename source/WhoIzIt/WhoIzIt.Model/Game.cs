using System.Collections.Generic;

namespace WhoIzIt.Model
{
    public class Game : BaseEntity
    {
        public Player Challenger { get; set; }
        public Player Opponent { get; set; }
        public IEnumerable<GamePiece> GamePieces { get; set; }
        public GameStatus Status { get; set; }
        public GamePiece ChallengerSelection { get; set; }
        public GamePiece OpponenetSelection { get; set; }
    }
}