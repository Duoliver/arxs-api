namespace ArxsAPI.Models
{
    public class Score : Entity
    {
        public int Position { get; set; }

        public int PointsAmount { get; set; }

        public int ScoreSystemId { get; set; }


        public ScoreSystem ScoreSystem { get; set; } = null!;


        public Score() { }
    }
}
