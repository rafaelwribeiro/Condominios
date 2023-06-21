using Backend.Domain.Repositories;
using MediatR;

namespace Backend.Application.Commands.AddApartment;

public class AddApartmentCommandHandler : IRequestHandler<AddApartmentCommand, AddApartmentCommandResult>
{
    private readonly IApartmentRepository _apartmentRepository;

    public AddApartmentCommandHandler(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }
    
    public async Task<AddApartmentCommandResult> Handle(AddApartmentCommand request, CancellationToken cancellationToken)
    {

        var result = new AddApartmentCommandResult();
        
        return result;
    }
}