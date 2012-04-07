namespace GameApp.WebRole.Models {
    public class GamePiece {

        public int Id { get; set; }
        public long FacebookId { get; set; }
        public bool Player1Status { get; set; }
        public bool Player2Status { get; set; }
        public Game Game { get; set; }

    }
}