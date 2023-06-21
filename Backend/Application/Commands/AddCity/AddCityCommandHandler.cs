using Backend.Application.Contracts;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.AddCity;

public class AddCityCommandHandler : IRequestHandler<AddCityCommand, AddCityCommandResult>
{
    private readonly ICityRepository _cityRepository;

    public AddCityCommandHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }
    
    public async Task<AddCityCommandResult> Handle(AddCityCommand request, CancellationToken cancellationToken)
    {
        var city = request.Contract.Adapt<City>();

        var createdCity = await _cityRepository.AddAsync(city);

        var result = new AddCityCommandResult();
        result.City = createdCity.Adapt<ReadCityContract>();
        return result;
    }
}