using Backend.Application.Contracts;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.GetCity;

public class GetCityCommandHandler : IRequestHandler<GetCityCommand, GetCityCommandResult>
{
    private readonly ICityRepository _cityRepository;

    public GetCityCommandHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }
    
    public async Task<GetCityCommandResult> Handle(GetCityCommand request, CancellationToken cancellationToken)
    {
        var city = await _cityRepository.GetAsync(request.Id);

        var result = new GetCityCommandResult();
        result.City = city.Adapt<ReadCityContract>();
        return result;
    }
}