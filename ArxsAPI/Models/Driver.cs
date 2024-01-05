namespace ArxsAPI.Models
{
    public class Driver : Entity
    {
        public string Name { get; set; } = null!;

        public string Surname { get; set; } = null!;

        public DateOnly? DateOfBirth { get; set; }

        public string? CityOfOrigin { get; set; }

        public int CountryOfOriginId { get; set; }

        public int NationalityId { get; set; }


        public Country CountryOfOrigin { get; set; } = null!;

        public Country Nationality { get; set; } = null!;

        public ICollection<TeamChampionshipSeasonDriver> TeamsEntries { get; } = new List<TeamChampionshipSeasonDriver>();


        public Driver() { }

        public Driver(
            string name,
            string surname,
            int countryOfOriginId,
            int nationalityId
        ) {
            Name = name;
            Surname = surname;
            CountryOfOriginId = countryOfOriginId;
            NationalityId = nationalityId;
        }
    }
}
