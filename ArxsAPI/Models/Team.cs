using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class Team : Entity
    {
        public string Name { get; set; } = null!;

        public int CountryId { get; set; }

        public int? PreviousTeamId { get; set; }


        public Country Country { get; set; } = null!;
        
        public Team? PreviousTeam { get; set; } = null!;

        public Team? NextTeam { get; set; } = null!;

        [JsonIgnore]
        public ICollection<TeamChampionshipSeason> Entries { get; set; } = [];

        [JsonIgnore]
        public ICollection<TeamCar> Cars { get; set; } = [];


        public Team() { }

        public Team(
            string name,
            int countryId,
            int? previousTeamId
        )
        {
            Name = name;
            CountryId = countryId;
            PreviousTeamId = previousTeamId;
        }
    }
}
