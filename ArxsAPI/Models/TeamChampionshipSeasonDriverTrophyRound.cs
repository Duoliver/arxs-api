using System.Text.Json.Serialization;
using ArxsAPI.Enums;

namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonDriverTrophyRound : Entity
    {
        public int Position { get; set; }

        public TrophyRoundDriverStatus Status { get; set; }
        
        public int DriverEntryId { get; set; }

        public int TrophyRoundId { get; set; }


        [JsonIgnore]
        public TeamChampionshipSeasonDriver DriverEntry { get; set; } = null!;

        [JsonIgnore]
        public ChampionshipSeasonTrophyRound TrophyRound { get; set; } = null!;


        public TeamChampionshipSeasonDriverTrophyRound() { }
    }
}
