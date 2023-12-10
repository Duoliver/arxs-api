namespace ArxsAPI.Models
{
    public class ChampionshipSeasonTrophy : BaseModel
    {
        public string Name { get; set; }

        public int ScoreSystemId { get; set; }

        public int ChampionshipSeasonId { get; set; }


        public ScoreSystem ScoreSystem { get; set; } = null!;

        public ChampionshipSeason ChampionshipSeason { get; set; } = null!;

        public ICollection<TeamChampionshipSeason> Entries { get; set; } = new List<TeamChampionshipSeason>();

        public ICollection<ChampionshipSeasonTrophyRound> TrophyRounds { get; } = new List<ChampionshipSeasonTrophyRound>();


        public ChampionshipSeasonTrophy() { }
    }
}
