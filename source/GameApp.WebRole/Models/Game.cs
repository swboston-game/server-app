using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameApp.WebRole.Models
{
    public class Game
    {

        public int Id { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime? EndedOn { get; set; }
        public DateTime LastTurnOn { get; set; }
        public User Player1 { get; set; }
        public User Player2 { get; set; }
        public int Turns { get; set; }
        public bool IsActive { get; set; }
        public User CurrentPlayer { get; set; }
        public User Winner { get; set; }
        public List<GameMove> Moves { get; set; }
        public List<GamePiece> Pieces { get; set; }
        public GamePiece Player1CorrectAnswer { get; set; }
        public GamePiece Player2CorrectAnswer { get; set; }
    }
}