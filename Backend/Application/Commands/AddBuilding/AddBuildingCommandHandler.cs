using Backend.Application.Contracts;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.AddBuilding;

public class AddBuildingCommandHandler : IRequestHandler<AddBuildingCommand, AddBuildingCommandResult>
{
    private readonly IBuildingRepository _buildingRepository;

    public AddBuildingCommandHandler(IBuildingRepository buildingRepository)
    {
        _buildingRepository = buildingRepository;
    }
    
    public async Task<AddBuildingCommandResult> Handle(AddBuildingCommand request, CancellationToken cancellationToken)
    {
        var entity = request.Contract.Adapt<Building>();
        var building = await _buildingRepository.AddAsync(entity);
        Console.WriteLine($"Cidade: {building.CityId}  nome: {building.Name}");
        var result = new AddBuildingCommandResult();
        result.Building = building.Adapt<ReadBuildingContract>();
        return result;
    }
}