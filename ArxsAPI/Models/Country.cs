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


        public Country() { } 
    }
}
