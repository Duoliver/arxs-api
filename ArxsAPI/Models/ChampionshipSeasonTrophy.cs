using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class ChampionshipSeasonTrophy : Entity
    {
        public string Name { get; set; } = null!;

        public int ScoreSystemId { get; set; }

        public int ChampionshipSeasonId { get; set; }


        [JsonIgnore]
        public ScoreSystem ScoreSystem { get; set; } = null!;

        [JsonIgnore]
        public ChampionshipSeason ChampionshipSeason { get; set; } = null!;

        [JsonIgnore]
        public ICollection<TeamChampionshipSeasonTrophy> TrophyEntries { get; set; } = [];

        [JsonIgnore]
        public ICollection<ChampionshipSeasonTrophyRound> TrophyRounds { get; } = [];


        public ChampionshipSeasonTrophy() { }
    }
}
