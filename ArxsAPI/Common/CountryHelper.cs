using ArxsAPI.Exceptions;
using ArxsAPI.Models;

namespace ArxsAPI.Common
{
    public class CountryHelper
    {
        public static Country FindCountry(string iso3, List<Country> list)
        {
            var country = list.Find(c => c.Iso3 == iso3);
            if (country == null)
            {
                throw new CountryNotFoundException($"No country was found with the ISO-3: { iso3 }");
            }
            return country;
        }
    }
}