using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.UpdateCity;

public class UpdateCityCommandHandler : IRequestHandler<UpdateCityCommand, UpdateCityCommandResult>
{
    private readonly ICityRepository _cityRepository;

    public UpdateCityCommandHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }
    
    public async Task<UpdateCityCommandResult> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
    {
        var city = await _cityRepository.GetAsync(request.Contract.Id);

        if(city==null)
            throw new NotFoundException();

        request.Contract.Adapt(city);

        await _cityRepository.UpdateAsync(city);

        var result = new UpdateCityCommandResult();

        return result;
    }
}