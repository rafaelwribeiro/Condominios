using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.UpdateBuilding;

public class UpdateBuildingCommand : IRequest<UpdateBuildingCommandResult>
{
    public UpdateBuildingContract Contract { get; set; }
    public UpdateBuildingCommand(UpdateBuildingContract contract)
    {
        Contract = contract;
    }
}