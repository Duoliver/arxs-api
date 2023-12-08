namespace ArxsAPI.Models
{
    public class ChampionshipSeason : BaseModel
    {
        public int SeasonId { get; set; }

        public int ChampionshipId { get; set; }

        // TODO add relationship lists

        public ChampionshipSeason() { }
    }
}