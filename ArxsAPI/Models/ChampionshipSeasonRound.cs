namespace ArxsAPI.Models
{
    public class ChampionshipSeasonRound : BaseModel
    {
        public string? Name { get; set; }
        
        public int ChampionshipSeasonId { get; set; }

        public int TrackConfigurationId { get; set; }


        public ChampionshipSeason ChampionshipSeason { get; set; }

        public TrackConfiguration TrackConfiguration { get; set; }


        public ChampionshipSeasonRound() { }
    }
}