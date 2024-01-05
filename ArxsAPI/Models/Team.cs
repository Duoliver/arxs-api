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

        // TODO descomentar atributos ao integrá-los ao banco
        // public ICollection<TeamChampionshipSeason> Entries { get; set; } = new List<TeamChampionshipSeason>();

        // public ICollection<TeamCar> Cars { get; set; } = new List<TeamCar>();


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
