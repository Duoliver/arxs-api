using System.ComponentModel.DataAnnotations;

namespace ArxsAPI.Models
{
    public class TeamCar : Entity
    {
        public string? Suffix { get; set; }

        [Length(4, 4)]
        public int? Year { get; set; }

        public int CarModelId { get; set; }

        public int TeamId { get; set; }


        public Car CarModel { get; set; } = null!;

        public Team Team { get; set; } = null!;

        public ICollection<TeamChampionshipSeasonDriverCar> DriversVariants { get; } = [];


        public TeamCar() { }
    }
}
