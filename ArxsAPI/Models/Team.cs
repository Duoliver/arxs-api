namespace ArxsAPI.Models
{
    public class Team : BaseModel
    {
        public string Name { get; set; }

        public int CountryId { get; set; }

        public int? PreviousTeamId { get; set; }

        public int? NextTeamId { get; set; }


        public Team? PreviousTeam { get; set; }

        public Team? NextTeam { get; set; }


        public Team() { }
    }
}