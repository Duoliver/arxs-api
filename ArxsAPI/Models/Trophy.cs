using System.Text.Json.Serialization;
using ArxsAPI.Enums;

namespace ArxsAPI.Models
{
    public class Trophy(string name, TrophyType type) : Entity
    {
        public string Name { get; set; } = name;

        public TrophyType Type { get; set; } = type;


        [JsonIgnore]
        public ICollection<ChampionshipSeasonTrophy> ChampionshipSeasonTrophies { get; set; } = [];
    }
}