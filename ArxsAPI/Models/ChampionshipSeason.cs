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
        public Season Season { get; set; } = null!;

        [JsonIgnore]
        public ICollection<ChampionshipSeasonTrophy> Trophies { get; } = [];

        [JsonIgnore]
        public ICollection<ChampionshipSeasonRound> Rounds { get; } = [];

        [JsonIgnore]
        public ICollection<TeamChampionshipSeason> Entries { get; set; } = [];


        public ChampionshipSeason() { }

        public ChampionshipSeason(int seasonId, int championshipId)
        {
            this.SeasonId = seasonId;
            this.ChampionshipId = championshipId;
        }
    }
}
