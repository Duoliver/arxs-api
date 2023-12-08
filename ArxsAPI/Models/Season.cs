using ArxsAPI.Models;

namespace ArxsAPI
{
    public class Season : BaseModel
    {
        public string Name { get; set; }

        // TODO fixed size 4
        public int Year { get; set; }


        // TODO add relationship lists


        public Season() { }
    }
}