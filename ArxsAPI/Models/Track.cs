namespace ArxsAPI.Models
{
    public class Track: BaseModel
    {
        public string Name { get; set; }

        public string? City { get; set; }

        public int CountryId { get; set; }


        public Country Country { get; set; }

        public ICollection<TrackConfiguration> TrackConfigurations { get; } = new List<TrackConfiguration>();


        public Track() { }
    }
}