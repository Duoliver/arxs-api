using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class Track : Entity
    {
        public string Name { get; set; } = null!;

        public string? City { get; set; }

        public int CountryId { get; set; }


        public Country Country { get; set; } = null!;

        [JsonIgnore]
        public ICollection<TrackConfiguration> TrackConfigurations { get; } = new List<TrackConfiguration>();


        public Track() { }

        public Track(string name, int countryId)
        {
            Name = name;
            CountryId = countryId;
        }
    }
}
