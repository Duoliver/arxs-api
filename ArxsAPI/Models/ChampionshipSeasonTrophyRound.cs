namespace ArxsAPI.Models
{
    public class ChampionshipSeasonTrophyRound : BaseModel
    {
        public int Order { get; set; }

        public int TrophyId { get; set; }

        public int RoundId { get; set; }


        public ChampionshipSeasonTrophy Trophy { get; set; } = null!;

        public ChampionshipSeasonRound Round { get; set; } = null!;
    }
}