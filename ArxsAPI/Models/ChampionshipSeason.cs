namespace ArxsAPI.Models
{
    public class ChampionshipSeason : Entity
    {
        public int SeasonId { get; set; }

        public int ChampionshipId { get; set; }


        public ICollection<ChampionshipSeasonTrophy> Trophies { get; } = new List<ChampionshipSeasonTrophy>();

        public ICollection<ChampionshipSeasonRound> Rounds { get; } = new List<ChampionshipSeasonRound>();

        public ICollection<TeamChampionshipSeason> Entries { get; set; } = new List<TeamChampionshipSeason>();


        public ChampionshipSeason() { }
    }
}
