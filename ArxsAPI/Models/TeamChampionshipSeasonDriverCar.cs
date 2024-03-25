using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class TeamChampionshipSeasonDriverCar : Entity
    {
        public int TeamCarId { get; set; }

        public int DriverEntryId { get; set; }

        
        [JsonIgnore]
        public TeamCar TeamCar { get; set; } = null!;

        [JsonIgnore]
        public TeamChampionshipSeasonDriver DriverEntry { get; set; } = null!;


        public TeamChampionshipSeasonDriverCar() { }
    }
}
