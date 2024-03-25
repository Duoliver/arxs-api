using System.ComponentModel.DataAnnotations;

namespace ArxsAPI.Models
{
    public class Season : Entity
    {
        public string Name { get; set; } = null!;

        [Length(4, 4)]
        public int Year { get; set; }


        public ICollection<ChampionshipSeason> ChampionshipSeasons { get; } = [];


        public Season() { }
    }
}
