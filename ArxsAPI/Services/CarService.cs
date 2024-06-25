using ArxsAPI.Common;
using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class CarService(
        CarRepository repository,
        ManufacturerService manufacturerService,
        CsvService csvService
        ) : EntityService<Car>(repository), IImportableEntityService<Car>
    {
        private readonly CarRepository Repository = repository;
        private readonly ManufacturerService ManufacturerService = manufacturerService;
        private readonly CsvService CsvService = csvService;

        public async Task<List<Car>> Import(Stream file)
        {
            List<string[]> values = CsvService.GetStringsFromFile(file, ',');
            List<Car> cars = [];

            List<Manufacturer> manufacturers = await ManufacturerService.GetAll();

            if (manufacturers.Count == 0)
            {
                throw new ManufacturerNotFoundException("No manufacturers were found");
            }

            values.ForEach(row =>
                {
                    string name = row[0];
                    string manufacturerName = row[1];
                    int year = int.Parse(row[2]);
                    string alias = row[3];

                    var manufacturer = ManufacturerHelper.FindManufacturer(manufacturerName, manufacturers);

                    cars.Add(new Car(name, year, alias, manufacturer.Id));
                }
            );

            await Repository.AddMany(cars);

            return cars;
        }
    }
}