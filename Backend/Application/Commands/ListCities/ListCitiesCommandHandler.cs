using Backend.Application.Contracts;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.ListCities;

public class ListCitiesCommandHandler : IRequestHandler<ListCitiesCommand, ListCitiesCommandResult>
{
    private readonly ICityRepository _cityRepository;

    public ListCitiesCommandHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }
    
    public async Task<ListCitiesCommandResult> Handle(ListCitiesCommand request, CancellationToken cancellationToken)
    {
        var cities = await _cityRepository.GetAllAsync();

        var result = new ListCitiesCommandResult();
        result.Cities = cities.Adapt<IList<ReadCityContract>>();
        return result;
    }
}