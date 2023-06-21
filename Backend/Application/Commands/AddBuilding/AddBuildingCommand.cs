using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.AddBuilding;

public class AddBuildingCommand : IRequest<AddBuildingCommandResult>
{
    public CreateBuildingContract Contract { get; set; }
    public AddBuildingCommand(CreateBuildingContract contract)
    {
        Contract = contract;
    }
}