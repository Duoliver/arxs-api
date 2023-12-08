namespace ArxsAPI.Models
{
    public class ScoreSystem : BaseModel
    {
        public ICollection<Score> Scores { get; } = new List<Score>();

        public ScoreSystem() { }
    }
}