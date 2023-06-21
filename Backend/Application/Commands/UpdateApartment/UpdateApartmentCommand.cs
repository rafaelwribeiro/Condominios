using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.UpdateApartment;

public class UpdateApartmentCommand : IRequest<UpdateApartmentCommandResult>
{
    public UpdateApartmentContract Contract { get; set; }
    public UpdateApartmentCommand(UpdateApartmentContract contract)
    {
        Contract = contract;
    }
}