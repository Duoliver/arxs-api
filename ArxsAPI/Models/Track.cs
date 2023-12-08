namespace ArxsAPI.Models
{
    public class Track: BaseModel
    {
        public string Name { get; set; }

        public string? City { get; set; }

        public int CountryId { get; set; }


        public Country Country { get; set; }

        // TODO add relationship lists

        public Track() { }
    }
}