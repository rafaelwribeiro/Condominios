using MediatR;

namespace Backend.Application.Commands.RemoveBuilding;

public class RemoveBuildingCommand : IRequest<RemoveBuildingCommandResult>
{
    public int Id { get; set; }
    public RemoveBuildingCommand(int id)
    {
        Id = id;
    }
}