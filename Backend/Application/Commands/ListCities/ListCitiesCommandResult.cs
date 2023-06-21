using Backend.Application.Contracts;

namespace Backend.Application.Commands.ListCities;

public class ListCitiesCommandResult
{
    public IList<ReadCityContract> Cities { get; set; } = new List<ReadCityContract>();
}