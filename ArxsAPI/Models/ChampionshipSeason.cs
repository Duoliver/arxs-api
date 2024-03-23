using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class ChampionshipSeason : Entity
    {
        public int SeasonId { get; set; }

        public int ChampionshipId { get; set; }

        [JsonIgnore]
        public Championship Championship { get; set; } = null!;

        [JsonIgnore]
        public ICollection<ChampionshipSeasonTrophy> Trophies { get; } = new List<ChampionshipSeasonTrophy>();

        [JsonIgnore]
        public ICollection<ChampionshipSeasonRound> Rounds { get; } = new List<ChampionshipSeasonRound>();

        [JsonIgnore]
        public ICollection<TeamChampionshipSeason> Entries { get; set; } = new List<TeamChampionshipSeason>();


        public ChampionshipSeason() { }
    }
}
