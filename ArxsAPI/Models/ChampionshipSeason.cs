namespace ArxsAPI.Models
{
    public class ChampionshipSeason : BaseModel
    {
        public int SeasonId { get; set; }

        public int ChampionshipId { get; set; }

        public ICollection<Trophy> Trophies { get; } = new List<Trophy>();

        public ICollection<Round> Rounds { get; } = new List<Round>();

        public ChampionshipSeason() { }
    }
}