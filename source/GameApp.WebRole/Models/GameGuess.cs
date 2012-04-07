using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameApp.WebRole.Models
{
    public class GameGuess
    {
        public int Id { get; set; }
        public DateTime GuessedOn { get; set; }
        public User Player { get; set; }
        public Game Game { get; set; }
        public GamePiece Guess { get; set; }
        public bool Correct { get; set; }
    }
}