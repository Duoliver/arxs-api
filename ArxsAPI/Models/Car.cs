namespace ArxsAPI.Models
{
    public class Car : BaseModel
    {
        public string Name { get; set; }

        // TODO fixed size 4
        public int Year { get; set; }

        public int ManufacturerId { get; set; }


        public Manufacturer Manufacturer { get; set; } = null!;

        public ICollection<TeamCar> TeamCars { get; set; } = new List<TeamCar>();


        public Car() { }
    }
}