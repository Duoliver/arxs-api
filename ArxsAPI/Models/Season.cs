using ArxsAPI.Models;

namespace ArxsAPI
{
    public class Season : BaseModel
    {
        public string Name { get; set; }

        // TODO fixed size 4
        public int Year { get; set; }


        public ICollection<ChampionshipSeason> ChampionshipSeasons { get; } = new List<ChampionshipSeason>();


        public Season() { }
    }
}
