namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonDriver : BaseModel
    {
        public int DriverId { get; set; }

        public int EntryId { get; set; }

        public int? CountryId { get; set; }


        public Driver Driver { get; set; } = null!;

        public TeamChampionshipSeason Entry { get; set; } = null!;

        public Country? Country { get; set; } = null!;

        public TeamChampionshipSeasonDriverCar EntryCar { get; set; } = null!;


        public TeamChampionshipSeasonDriver() { }
    }
}
