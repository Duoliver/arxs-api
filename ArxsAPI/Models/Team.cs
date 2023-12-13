namespace ArxsAPI.Models
{
    public class Team : Entity
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public int? PreviousTeamId { get; set; }

        public int? NextTeamId { get; set; }


        public Team? PreviousTeam { get; set; } = null!;

        public Team? NextTeam { get; set; } = null!;


        public ICollection<TeamChampionshipSeason> Entries { get; set; } = new List<TeamChampionshipSeason>();

        public ICollection<TeamCar> Cars { get; set; } = new List<TeamCar>();


        public Team() { }
    }
}
