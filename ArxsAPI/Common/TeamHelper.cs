using ArxsAPI.Exceptions;
using ArxsAPI.Models;

namespace ArxsAPI.Common
{
    public class TeamHelper
    {
        public static Team FindTeam(string name, List<Team> list)
        {
            var team = list.Find(t => t.Name == name) 
                ?? throw new EntityNotFoundException($"No team was found with the following name: { name }");
            return team;
        }
    }
}