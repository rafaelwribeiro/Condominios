using Backend.Application.Contracts;

namespace Backend.Application.Commands.AddBuilding;

public class AddBuildingCommandResult
{
    public ReadBuildingContract? Building { get; set; }
}