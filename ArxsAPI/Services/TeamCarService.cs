using ArxsAPI.Common;
using ArxsAPI.Exceptions;
using ArxsAPI.Models;
using ArxsAPI.Repositories;

namespace ArxsAPI.Services
{
    public class TeamCarService(
        TeamCarRepository repository,
        TeamRepository teamRepository,
        CarRepository carRepository,
        CsvService csvService
    ) : EntityService<TeamCar>(repository), IImportableEntityService<TeamCar>
    {
        private readonly TeamCarRepository _repository = repository;
        private readonly TeamRepository _teamRepository = teamRepository;
        private readonly CarRepository _carRepository = carRepository;
        private readonly CsvService _csvService = csvService;

        public async Task<List<TeamCar>> Import(Stream file)
        {
            List<string[]> values = _csvService.GetStringsFromFile(file, ',');
            List<TeamCar> teamCars = [];

            List<Team> teams = await _teamRepository.GetAll()
                ?? throw new EntityNotFoundException("No teams were found");
            List<Car> cars = await _carRepository.GetAll()
                ?? throw new EntityNotFoundException("No cars were found");

            values.ForEach(row => 
                {
                    int year = int.Parse(row[0]);
                    string teamName = row[1];
                    string carModelAlias = row[2];
                    string suffix = row[3];

                    var team = TeamHelper.FindTeam(teamName, teams);
                    var car = CarHelper.FindCar(carModelAlias, cars);

                    if (car.Year > year)
                        throw new InvalidRequestException($"The team car year of { year } is invalid for the following car model: { car }");

                    teamCars.Add(new TeamCar(suffix, year, car.Id, team.Id));
                }
            );

            await _repository.AddMany(teamCars);

            return teamCars;
        }
    }
}