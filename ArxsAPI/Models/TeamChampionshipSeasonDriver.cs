using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonDriver : Entity
    {
        public int DriverId { get; set; }

        public int EntryId { get; set; }

        public int? CountryId { get; set; }


        [JsonIgnore]
        public Driver Driver { get; set; } = null!;

        [JsonIgnore]
        public TeamChampionshipSeason Entry { get; set; } = null!;

        [JsonIgnore]
        public Country? Country { get; set; } = null!;

        [JsonIgnore]
        public TeamChampionshipSeasonDriverCar EntryCar { get; set; } = null!;

        [JsonIgnore]
        public ICollection<TeamChampionshipSeasonDriverTrophyRound> EntryTrophyRounds { get; } = [];

        [JsonIgnore]
        public ICollection<TeamChampionshipSeasonDriverRoundRace> EntryRoundRaces { get; } = [];


        public TeamChampionshipSeasonDriver() { }
    }
}
