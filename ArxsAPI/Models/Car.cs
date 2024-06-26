using System.ComponentModel.DataAnnotations;

namespace ArxsAPI.Models
{
    public class Car : Entity
    {
        public string Name { get; set; } = null!;

        [Length(4, 4)]
        public int Year { get; set; }

        public string? Alias { get; set; }

        public int ManufacturerId { get; set; }


        public Manufacturer Manufacturer { get; set; } = null!;

        public ICollection<TeamCar> TeamCars { get; set; } = [];


        public Car() { }

        public Car(string name, int year, string alias, int manufacturerId)
        {
            Name = name;
            Year = year;
            ManufacturerId = manufacturerId;
            Alias = alias;
        }

        public override string ToString()
        {
            return $"{Year} {Name} ({Alias})";
        }
    }
}
