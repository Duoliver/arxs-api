using System.Text.Json.Serialization;

namespace ArxsAPI.Models
{
    public class Manufacturer : Entity
    {
        public string Name { get; set; }

        public int CountryId { get; set; }


        public Country Country { get; set; } = null!;

        [JsonIgnore]
        public ICollection<Car> Cars { get; } = new List<Car>();


        public Manufacturer(string name, int countryId)
        {
            Name = name;
            CountryId = countryId;
        }


        public Manufacturer() { }
    }
}
