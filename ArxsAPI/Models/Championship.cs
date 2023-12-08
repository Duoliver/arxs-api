namespace ArxsAPI.Models
{
    public class Championship : BaseModel
    {
        public string Name { get; set; }
        
        public int? PreviousChampionshipId { get; set; }

        public int? NextChampionshipId { get; set; }


        public Championship? PreviousChampionship { get; set; }

        public Championship? NextChampionship { get; set; }

        public ICollection<ChampionshipSeason> ChampionshipSeasons { get; } = new List<ChampionshipSeason>();


        public Championship() { }
    }
}