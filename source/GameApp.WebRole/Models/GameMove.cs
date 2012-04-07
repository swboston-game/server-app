using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameApp.WebRole.Models
{
    public class GameMove
    {

        public int Id { get; set; }
        public DateTime MovedOn { get; set; }
        public DateTime RespondedOn { get; set; }
        public User Player { get; set; }
        public string Question { get; set; }
        public bool? Answer { get; set; }
        public Game Game { get; set; }

    }
}