using System.Globalization;
using ArxsAPI.Exceptions;

namespace ArxsAPI.Common
{
    public static class DateHelper
    {
        public static DateOnly GetDateFromString(string rawDate)
        {
            bool couldConvert = DateOnly.TryParseExact(
                rawDate, "d/M/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly date
            );

            if (couldConvert)
            {
                return date;
            }
            throw new InvalidDateFormatException($"Could not convert {date} to d/M/yyyy format");
        }
    }
}