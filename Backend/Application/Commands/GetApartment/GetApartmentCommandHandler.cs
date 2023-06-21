using Backend.Application.Contracts;
using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.GetApartment;

public class GetApartmentCommandHandler : IRequestHandler<GetApartmentCommand, GetApartmentCommandResult>
{
    private readonly IApartmentRepository _apartmentRepository;

    public GetApartmentCommandHandler(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }
    
    public async Task<GetApartmentCommandResult> Handle(GetApartmentCommand request, CancellationToken cancellationToken)
    {
        var entity = await _apartmentRepository.GetAsync(request.Id);

        if(entity == null)
            throw new NotFoundException();

        var result = new GetApartmentCommandResult();
        result.Apartment = entity.Adapt<ReadApartmentContract>();
        return result;
    }
}