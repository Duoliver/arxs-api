namespace ArxsAPI.Models
{
    public class TeamChampionshipSeason : BaseModel
    {
        public int TeamId { get; set; }

        public int ChampionshipSeasonId { get; set; }

        public int? CountryId { get; set; }


        public ChampionshipSeason ChampionshipSeason { get; set; } = null!;

        public Country Country { get; set; } = null!;

        public TeamChampionshipSeason() { }
    }
}