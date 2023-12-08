namespace ArxsAPI.Models
{
    public class TrackConfiguration : BaseModel
    {
        public int Year { get; set; }

        public int TrackId { get; set; }


        public Track Track { get; set; }


        public TrackConfiguration() { }
    }
}