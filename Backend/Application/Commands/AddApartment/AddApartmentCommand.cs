using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.AddApartment;

public class AddApartmentCommand : IRequest<AddApartmentCommandResult>
{
    public CreateApartmentContract Contract { get; set; }
    public int BuildingId { get; set; }
    public AddApartmentCommand(int buildingId, CreateApartmentContract contract)
    {
        Contract = contract;
        BuildingId = buildingId;
    }
}