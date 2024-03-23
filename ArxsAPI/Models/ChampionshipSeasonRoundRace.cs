using System.Text.Json.Serialization;
using ArxsAPI.Enums;

namespace ArxsAPI.Models
{
    public class ChampionshipSeasonRoundRace : Entity
    {
        public int Order { get; set; }

        public RaceType Type { get; set; }

        public int LapCount { get; set; }

        public int RoundId { get; set; }


        [JsonIgnore]
        public ChampionshipSeasonRound Round { get; set; } = null!;

        [JsonIgnore]
        public ICollection<TeamChampionshipSeasonDriverRoundRace> DriversResults { get; } = [];


        public ChampionshipSeasonRoundRace() { }
    }
}
