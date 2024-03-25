using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class TeamCar : Entity
    {
        public string? Suffix { get; set; }

        [Length(4, 4)]
        public int? Year { get; set; }

        public int CarModelId { get; set; }

        public int TeamId { get; set; }


        [JsonIgnore]
        public Car CarModel { get; set; } = null!;

        [JsonIgnore]
        public Team Team { get; set; } = null!;

        [JsonIgnore]
        public ICollection<TeamChampionshipSeasonDriverCar> DriversVariants { get; } = [];


        public TeamCar() { }
    }
}
