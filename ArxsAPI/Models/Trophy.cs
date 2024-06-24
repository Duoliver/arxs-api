using System.Text.Json.Serialization;
using ArxsAPI.Enums;

namespace ArxsAPI.Models
{
    public class Trophy : Entity
    {
        public string Name { get; set; } = null!;

        public TrophyType Type { get; set; }


        [JsonIgnore]
        public ICollection<ChampionshipSeasonTrophy> ChampionshipSeasonTrophies { get; set; } = [];
    }
}