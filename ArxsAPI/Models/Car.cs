using System.ComponentModel.DataAnnotations;

namespace ArxsAPI.Models
{
    public class Car : Entity
    {
        public string Name { get; set; } = null!;

        [Length(4, 4)]
        public int Year { get; set; }

        public int ManufacturerId { get; set; }


        public Manufacturer Manufacturer { get; set; } = null!;

        public ICollection<TeamCar> TeamCars { get; set; } = [];


        public Car() { }

        public Car(string name, int year, int manufacturerId)
        {
            Name = name;
            Year = year;
            ManufacturerId = manufacturerId;
        }
    }
}
