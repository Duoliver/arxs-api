using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class ChampionshipSeasonTrophyRound : Entity
    {
        public int Order { get; set; }

        public int TrophyId { get; set; }

        public int RoundId { get; set; }


        [JsonIgnore]
        public ChampionshipSeasonTrophy Trophy { get; set; } = null!;

        [JsonIgnore]
        public ChampionshipSeasonRound Round { get; set; } = null!;

        public ICollection<TeamChampionshipSeasonDriverTrophyRound> DriversResults { get; } = new List<TeamChampionshipSeasonDriverTrophyRound>();


        public ChampionshipSeasonTrophyRound () { }
    }
}
