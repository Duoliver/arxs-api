using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class ChampionshipSeasonRound : Entity
    {
        public string? Name { get; set; }
        
        public int ChampionshipSeasonId { get; set; }

        public int TrackConfigurationId { get; set; }


        [JsonIgnore]
        public ChampionshipSeason ChampionshipSeason { get; set; } = null!;

        [JsonIgnore]
        public TrackConfiguration TrackConfiguration { get; set; } = null!;

        [JsonIgnore]
        public ICollection<ChampionshipSeasonTrophyRound> RoundTrophies { get; } = [];

        [JsonIgnore]
        public ICollection<ChampionshipSeasonRoundRace> RoundRaces { get; } = [];


        public ChampionshipSeasonRound() { }
    }
}
