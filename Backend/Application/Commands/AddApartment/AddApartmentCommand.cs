using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.AddApartment;

public class AddApartmentCommand : IRequest<AddApartmentCommandResult>
{
    public CreateApartmentContract Contract { get; set; }
    public AddApartmentCommand(CreateApartmentContract contract)
    {
        Contract = contract;
    }
}