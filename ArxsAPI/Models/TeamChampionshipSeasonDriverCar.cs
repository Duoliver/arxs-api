namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonDriverCar : BaseModel
    {
        public int TeamCarId { get; set; }

        public int DriverEntryId { get; set; }

        
        public TeamCar TeamCar { get; set; } = null!;

        public TeamChampionshipSeasonDriver DriverEntry { get; set; } = null!;


        public TeamChampionshipSeasonDriverCar() { }
    }
}