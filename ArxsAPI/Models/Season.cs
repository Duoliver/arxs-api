using System.ComponentModel.DataAnnotations;
using ArxsAPI.Models;

namespace ArxsAPI
{
    public class Season : BaseModel
    {
        public string Name { get; set; }

        [Length(4, 4)]
        public int Year { get; set; }


        public ICollection<ChampionshipSeason> ChampionshipSeasons { get; } = new List<ChampionshipSeason>();


        public Season() { }
    }
}
