﻿namespace WhoIzIt.Model
{
    public class Player : BaseEntity
    {
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string FaceBookId { get; set; }
        public int Streak { get; set; }
        public int Wins { get; set; }
        public int Loses { get; set; }
    }
}
