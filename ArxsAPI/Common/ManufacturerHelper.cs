using ArxsAPI.Exceptions;
using ArxsAPI.Models;

namespace ArxsAPI.Common
{
    public class ManufacturerHelper
    {
        public static Manufacturer FindManufacturer(string name, List<Manufacturer> list)
        {
            var manufacturer = list.Find(m => m.Name == name);
            if (manufacturer == null)
            {
                throw new ManufacturerNotFoundException($"No manufacturer was found with the following name: { name }");
            }
            return manufacturer;
        }
    }
}