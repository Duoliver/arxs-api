using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class Score : Entity
    {
        public int Position { get; set; }

        public int PointsAmount { get; set; }

        public int? ScoreSystemId { get; set; } = null;

        [JsonIgnore]
        public ScoreSystem ScoreSystem { get; set; } = null!;


        public Score() { }

        public Score(int position, int pointsAmount)
        {
            Position = position;
            PointsAmount = pointsAmount;
        }
    }
}
