namespace ArxsAPI.Models
{
    public class Championship : Entity
    {
        public string Name { get; set; } = null!;

        public string? Alias { get; set; }
        
        public int? PreviousChampionshipId { get; set; }

        public int? NextChampionshipId { get; set; }


        public Championship? PreviousChampionship { get; set; } = null!;

        public Championship? NextChampionship { get; set; } = null!;

        public ICollection<ChampionshipSeason> ChampionshipSeasons { get; } = new List<ChampionshipSeason>();


        public Championship() { }
    }
}
