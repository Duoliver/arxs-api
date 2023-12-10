namespace ArxsAPI.Models
{
    public class Driver : BaseModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public string? CityOfOrigin { get; set; }

        public int CountryOfOriginId { get; set; }

        public int NationalityId { get; set; }


        public Country CountryOfOrigin { get; set; } = null!;

        public Country Nationality { get; set; } = null!;

        public ICollection<TeamChampionshipSeasonDriver> TeamsEntries { get; } = new List<TeamChampionshipSeasonDriver>();


        public Driver() { }
    }
}
