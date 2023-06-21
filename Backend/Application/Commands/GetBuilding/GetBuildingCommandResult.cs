using Backend.Application.Contracts;

namespace Backend.Application.Commands.GetBuilding;

public class GetBuildingCommandResult
{
    public  ReadBuildingContract? Building { get; set; }
}