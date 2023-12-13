namespace ArxsAPI.Models
{
    public class Track : Entity
    {
        public string Name { get; set; }

        public string? City { get; set; }

        public int CountryId { get; set; }


        public Country Country { get; set; } = null!;

        public ICollection<TrackConfiguration> TrackConfigurations { get; } = new List<TrackConfiguration>();


        public Track() { }
    }
}
