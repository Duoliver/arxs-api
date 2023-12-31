namespace ArxsAPI.Models
{
    public class TeamChampionshipSeason : Entity
    {
        public string? Name { get; set; }

        public string? Colour { get; set; }


        public int TeamId { get; set; }

        public int ChampionshipSeasonId { get; set; }

        public int? CountryId { get; set; }


        public Team Team { get; set; } = null!;

        public ChampionshipSeason ChampionshipSeason { get; set; } = null!;

        public Country Country { get; set; } = null!;
        
        public ICollection<ChampionshipSeasonTrophy> Trophies { get; } = new List<ChampionshipSeasonTrophy>();

        public ICollection<TeamChampionshipSeasonDriver> DriversEntries { get; } = new List<TeamChampionshipSeasonDriver>();


        public TeamChampionshipSeason() { }
    }
}
