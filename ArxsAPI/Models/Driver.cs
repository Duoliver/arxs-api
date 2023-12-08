namespace ArxsAPI.Models
{
    public class Driver : BaseModel
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public int CountryOfOriginId { get; set; }

        public int NationalityId { get; set; }


        public Country CountryOfOrigin { get; set; }

        public Country Nationality { get; set; }


        public ICollection<TeamChampionshipSeasonDriver> TeamEntries { get; } = new List<TeamChampionshipSeasonDriver>();


        public Driver() { }
    }
}