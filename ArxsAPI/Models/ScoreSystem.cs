using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class ScoreSystem : Entity
    {
        public string Alias { get; set; } = null!;

        public ICollection<Score> Scores { get; set; } = [];

        [JsonIgnore]
        public ICollection<ChampionshipSeasonTrophy> Trophies { get; set; } = [];

        public ScoreSystem() { }
    }
}
