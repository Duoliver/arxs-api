namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonTrophy : Entity
    {
        public int EntryId { get; set; }

        public int TrophyId { get; set; }

        
        public TeamChampionshipSeason Entry { get; set; } = null!;

        public ChampionshipSeasonTrophy Trophy { get; set; } = null!;


        public TeamChampionshipSeasonTrophy() { }
    }
}
