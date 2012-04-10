using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoIzIt.Model;

namespace WhiIzIt.BLL
{
    public interface IGamePiecesService
    {
        ICollection<GamePiece> GenerateGamePieces(int challengerId, int opponentId);
    }
}
