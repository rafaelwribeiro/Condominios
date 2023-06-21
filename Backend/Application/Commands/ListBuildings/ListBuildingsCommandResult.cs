using Backend.Application.Contracts;

namespace Backend.Application.Commands.ListBuildings;

public class ListBuildingsCommandResult
{
    public IList<ReadBuildingContract> Buildings { get; set; } = new List<ReadBuildingContract>();
}