using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameApp.WebRole.Models
{
    public class GameInvite
    {

        public int Id { get; set; }
        public DateTime InvitedOn { get; set; }
        public DateTime? RespondedOn { get; set; }
        public User Invitor { get; set; }
        public User Invitee { get; set; }
        public string InviteCode { get; set; }
        public Game Game { get; set; }

    }
}