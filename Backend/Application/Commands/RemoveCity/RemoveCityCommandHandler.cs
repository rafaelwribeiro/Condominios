using Backend.Application.Contracts;
using Backend.Application.Exceptions;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.RemoveCity;

public class RemoveCityCommandHandler : IRequestHandler<RemoveCityCommand, RemoveCityCommandResult>
{
    private readonly ICityRepository _cityRepository;

    public RemoveCityCommandHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }
    
    public async Task<RemoveCityCommandResult> Handle(RemoveCityCommand request, CancellationToken cancellationToken)
    {
        var city = await _cityRepository.GetAsync(request.Id);
        if(city==null)
            throw new NotFoundException();
        await _cityRepository.RemoveAsync(city);
        var result = new RemoveCityCommandResult();
        return result;
    }
}