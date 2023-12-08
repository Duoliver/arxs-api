namespace ArxsAPI.Models
{
    public class Country : BaseModel
    {
        public string Name { get; set; }
        
        // TODO fixed size 3
        public string Iso3 { get; set; }

        public string Adjective { get; set; }

        public Country() { } 
    }
}