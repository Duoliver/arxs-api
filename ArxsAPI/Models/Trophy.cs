namespace ArxsAPI.Models
{
    public class Trophy : BaseModel
    {
        public string Name { get; set; }

        public int ScoreSystemId { get; set; }

        public int ChampionshipSeasonId { get; set; }


        public ScoreSystem ScoreSystem { get; set; }

        public ChampionshipSeason ChampionshipSeason { get; set; }


        public Trophy() { }
    }
}