using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class TeamChampionshipSeason : Entity
    {
        public string? Name { get; set; }

        public string? Colour { get; set; }


        public int TeamId { get; set; }

        public int ChampionshipSeasonId { get; set; }

        public int? CountryId { get; set; }


        [JsonIgnore]
        public Team Team { get; set; } = null!;

        [JsonIgnore]
        public ChampionshipSeason ChampionshipSeason { get; set; } = null!;

        [JsonIgnore]
        public Country Country { get; set; } = null!;
        
        [JsonIgnore]
        public ICollection<ChampionshipSeasonTrophy> Trophies { get; } = [];

        [JsonIgnore]
        public ICollection<TeamChampionshipSeasonDriver> DriversEntries { get; } = [];


        public TeamChampionshipSeason() { }
    }
}
