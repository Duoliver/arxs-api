namespace ArxsAPI.Models
{
    public class Manufacturer : BaseModel
    {
        public string Name { get; set; }

        public int CountryId { get; set; }


        public Country Country { get; set; }

        // TODO add relationship lists


        public Manufacturer() { }
    }
}