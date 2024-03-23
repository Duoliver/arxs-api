using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class Country : Entity
    {
        public string Name { get; set; } = null!;
        
        [StringLength(3, MinimumLength = 3)]
        public string Iso3 { get; set; } = null!;

        public string Adjective { get; set; } = null!;

        [JsonIgnore]
        public ICollection<Team> Teams { get; } = [];

        [JsonIgnore]
        public ICollection<Driver> NationalDrivers { get; } = [];

        [JsonIgnore]
        public ICollection<Driver> NativeDrivers { get; } = [];

        [JsonIgnore]
        public ICollection<Manufacturer> Manufacturers { get; } = [];

        [JsonIgnore]
        public ICollection<Track> Tracks { get; } = [];

        public Country() { } 
    }
}
