using ArxsAPI.Enums;

namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonDriverRoundRace : Entity
    {
        public int Position { get; set; }

        public RoundRaceDriverStatus Status { get; set; }

        public int DriverEntryId { get; set; }

        public int RoundRaceId { get; set; }


        public TeamChampionshipSeasonDriver DriverEntry { get; set; } = null!;

        public ChampionshipSeasonRoundRace RoundRace { get; set; } = null!;


        public TeamChampionshipSeasonDriverRoundRace() { }
    }
}
