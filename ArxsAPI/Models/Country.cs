using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class Country : Entity
    {
        public string Name { get; set; }
        
        [StringLength(3, MinimumLength = 3)]
        public string Iso3 { get; set; }

        public string Adjective { get; set; }

        [JsonIgnore]
        public ICollection<Team> Teams { get; } = new List<Team>();

        [JsonIgnore]
        public ICollection<Driver> NationalDrivers { get; } = new List<Driver>();

        [JsonIgnore]
        public ICollection<Driver> NativeDrivers { get; } = new List<Driver>();

        [JsonIgnore]
        public ICollection<Manufacturer> Manufacturers { get; } = new List<Manufacturer>();

        [JsonIgnore]
        public ICollection<Track> Tracks { get; } = new List<Track>();

        public Country() { } 
    }
}
