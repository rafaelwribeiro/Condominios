using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.UpdateApartment;

public class UpdateApartmentCommandHandler : IRequestHandler<UpdateApartmentCommand, UpdateApartmentCommandResult>
{
    private readonly IApartmentRepository _apartmentRepository;

    public UpdateApartmentCommandHandler(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }
    
    public async Task<UpdateApartmentCommandResult> Handle(UpdateApartmentCommand request, CancellationToken cancellationToken)
    {
        var entity = await _apartmentRepository.GetAsync(request.Contract.Id);

        if(entity==null)
            throw new NotFoundException();

        request.Contract.Adapt(entity);

        await _apartmentRepository.UpdateAsync(entity);

        return new UpdateApartmentCommandResult();
    }
}