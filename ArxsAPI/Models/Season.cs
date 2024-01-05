using System.ComponentModel.DataAnnotations;
using ArxsAPI.Models;

namespace ArxsAPI
{
    public class Season : Entity
    {
        public string Name { get; set; } = null!;

        [Length(4, 4)]
        public int Year { get; set; }


        public ICollection<ChampionshipSeason> ChampionshipSeasons { get; } = new List<ChampionshipSeason>();


        public Season() { }
    }
}
