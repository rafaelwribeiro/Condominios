using Backend.Application.Contracts;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.ListBuildings;

public class ListCitiesCommandHandler : IRequestHandler<ListBuildingsCommand, ListBuildingsCommandResult>
{
    private readonly IBuildingRepository _buildingRepository;

    public ListCitiesCommandHandler(IBuildingRepository buildingRepository)
    {
        _buildingRepository = buildingRepository;
    }
    
    public async Task<ListBuildingsCommandResult> Handle(ListBuildingsCommand request, CancellationToken cancellationToken)
    {
        var buildings = await _buildingRepository.GetAllAsync();

        var result = new ListBuildingsCommandResult();
        result.Buildings = buildings.Adapt<IList<ReadBuildingContract>>();
        return result;
    }
}