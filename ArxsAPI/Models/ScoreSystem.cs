namespace ArxsAPI.Models
{
    public class ScoreSystem : Entity
    {
        public ICollection<Score> Scores { get; } = new List<Score>();

        public ScoreSystem() { }
    }
}
