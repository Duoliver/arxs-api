namespace ArxsAPI.Models
{
    public class ChampionshipSeasonRound : BaseModel
    {
        public string? Name { get; set; }
        
        public int ChampionshipSeasonId { get; set; }

        public int TrackConfigurationId { get; set; }


        public ChampionshipSeason ChampionshipSeason { get; set; } = null!;

        public TrackConfiguration TrackConfiguration { get; set; } = null!;

        public ICollection<ChampionshipSeasonTrophyRound> RoundTrophies { get; } = new List<ChampionshipSeasonTrophyRound>();

        public ICollection<ChampionshipSeasonRoundRace> RoundRaces { get; } = new List<ChampionshipSeasonRoundRace>();


        public ChampionshipSeasonRound() { }
    }
}
