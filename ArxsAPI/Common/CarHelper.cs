using ArxsAPI.Exceptions;
using ArxsAPI.Models;

namespace ArxsAPI.Common
{
    public class CarHelper
    {
        public static Car FindCar(string alias, List<Car> list)
        {
            var car = list.Find(c => c.Alias == alias) 
                ?? throw new EntityNotFoundException($"No car was found with the following alias: { alias }");
            return car;
        }
    }
}