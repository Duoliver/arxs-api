namespace ArxsAPI.Models
{
    public class ScoreSystem : Entity
    {
        public string Alias { get; set; } = null!;

        public ICollection<Score> Scores { get; set; } = [];

        public ScoreSystem() { }
    }
}
