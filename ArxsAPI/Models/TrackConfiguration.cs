namespace ArxsAPI.Models
{
    public class TrackConfiguration : Entity
    {
        public int Year { get; set; }

        public int TrackId { get; set; }


        public Track Track { get; set; } = null!;

        public ICollection<ChampionshipSeasonRound> Rounds { get; } = new List<ChampionshipSeasonRound>();


        public TrackConfiguration() { }
    }
}
