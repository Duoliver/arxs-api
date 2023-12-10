namespace ArxsAPI.Models
{
    public class TeamCar : BaseModel
    {
        public string? Suffix { get; set; }

        // TODO fixed length 4
        public int? Year { get; set; }

        public int CarModelId { get; set; }

        public int TeamId { get; set; }


        public Car CarModel { get; set; } = null!;

        public Team Team { get; set; } = null!;

        public ICollection<TeamChampionshipSeasonDriverCar> DriversVariants { get; } = new List<TeamChampionshipSeasonDriverCar>();


        public TeamCar() { }
    }
}
