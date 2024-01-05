using ArxsAPI.Exceptions;
using ArxsAPI.Models;

namespace ArxsAPI.Common
{
    public class TrackHelper
    {
        public static Track FindByName(string name, List<Track> list)
        {
            var track = list.Find(track => track.Name == name);

            if (EmptyHelper.IsEmpty(track))
            {
                throw new TrackNotFoundException($"No track was found with the name {name}");
            }
            return track!;
        }
    }
}