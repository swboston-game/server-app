using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameApp.WebRole.Models {
    public class GamePiece {

        public int Id { get; set; }
        public long FacebookId { get; set; }
        public Game Game { get; set; }

    }
}