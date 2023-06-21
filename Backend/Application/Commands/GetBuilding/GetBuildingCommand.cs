using MediatR;

namespace Backend.Application.Commands.GetBuilding;

public class GetBuildingCommand : IRequest<GetBuildingCommandResult>
{
    public int Id { get; set; }
    public GetBuildingCommand(int id)
    {
        Id = id;
    }
}