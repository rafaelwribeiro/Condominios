using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using MediatR;

namespace Backend.Application.Commands.RemoveApartment;

public class RemoveApartmentCommandHandler : IRequestHandler<RemoveApartmentCommand, RemoveApartmentCommandResult>
{
    private readonly IApartmentRepository _apartmentRepository;

    public RemoveApartmentCommandHandler(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }
    
    public async Task<RemoveApartmentCommandResult> Handle(RemoveApartmentCommand request, CancellationToken cancellationToken)
    {
        var entity = await _apartmentRepository.GetAsync(request.Id);
        if(entity==null)
            throw new NotFoundException();
        await _apartmentRepository.RemoveAsync(entity);
        return new RemoveApartmentCommandResult();
    }
}