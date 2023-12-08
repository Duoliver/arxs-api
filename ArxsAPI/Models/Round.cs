namespace ArxsAPI.Models
{
    public class Round : BaseModel
    {
        public int ChampionshipSeasonId { get; set; }

        public int TrackConfigurationId { get; set; }


        public ChampionshipSeason ChampionshipSeason { get; set; }

        public TrackConfiguration TrackConfiguration { get; set; }


        public Round() { }
    }
}