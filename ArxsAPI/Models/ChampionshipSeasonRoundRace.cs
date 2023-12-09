using ArxsAPI.Enums;

namespace ArxsAPI.Models
{
    public class ChampionshipSeasonRoundRace : BaseModel
    {
        public int Order { get; set; }

        public RaceType Type { get; set; }

        public int LapCount { get; set; }

        public int RoundId { get; set; }


        public ChampionshipSeasonRound Round { get; set; } = null!;

        public ICollection<TeamChampionshipSeasonDriverRoundRace> DriversResults { get; } = new List<TeamChampionshipSeasonDriverRoundRace>();


        public ChampionshipSeasonRoundRace() { }
    }
}