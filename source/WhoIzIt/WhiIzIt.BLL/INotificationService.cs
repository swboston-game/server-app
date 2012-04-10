using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiIzIt.BLL
{
    public interface INotificationService
    {
        void InviteAccepted(int challengerId);
        void InviteDeclined(int challengerId);
        void QuestionAsked(int p);
        void QuestionAnswered(int questionId);
        void GameOver(int gameId);
        void Invite(int id);
    }
}
