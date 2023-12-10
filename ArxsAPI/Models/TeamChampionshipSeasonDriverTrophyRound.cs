using ArxsAPI.Enums;

namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonDriverTrophyRound : BaseModel
    {
        public int Position { get; set; }

        public TrophyRoundDriverStatus Status { get; set; }
        
        public int DriverEntryId { get; set; }

        public int TrophyRoundId { get; set; }


        public TeamChampionshipSeasonDriver DriverEntry { get; set; } = null!;

        public ChampionshipSeasonTrophyRound TrophyRound { get; set; } = null!;


        public TeamChampionshipSeasonDriverTrophyRound() { }
    }
}