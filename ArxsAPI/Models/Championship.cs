using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class Championship : Entity
    {
        public string Name { get; set; } = null!;

        public string? Alias { get; set; }
        
        public int? PredecessorId { get; set; }


        [JsonIgnore]
        public Championship? Predecessor { get; set; } = null!;

        [JsonIgnore]
        public Championship? Successor { get; set; } = null!;

        [JsonIgnore]
        public ICollection<ChampionshipSeason> ChampionshipSeasons { get; } = new List<ChampionshipSeason>();


        public Championship() { }
    }
}
