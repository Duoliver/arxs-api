using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class TrackConfiguration : Entity
    {
        public string Name { get; set; } = null!;

        public int Year { get; set; }

        public int TrackId { get; set; }


        public Track Track { get; set; } = null!;

        [JsonIgnore]
        public ICollection<ChampionshipSeasonRound> Rounds { get; } = [];


        public TrackConfiguration() { }

        public TrackConfiguration(string name, int year, int trackId)
        {
            Name = name;
            Year = year;
            TrackId = trackId;
        }
    }
}
