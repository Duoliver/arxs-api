namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonDriver : BaseModel
    {
        public int DriverId { get; set; }

        public int EntryId { get; set; }

        public int? CountryId { get; set; }


        public Driver Driver { get; set; }

        public TeamChampionshipSeason Entry { get; set; }

        public Country? Country { get; set; }


        public TeamChampionshipSeasonDriver() { }
    }
}