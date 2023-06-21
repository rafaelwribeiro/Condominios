using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using MediatR;

namespace Backend.Application.Commands.RemoveBuilding;

public class RemoveBuildingCommandHandler : IRequestHandler<RemoveBuildingCommand, RemoveBuildingCommandResult>
{
    private readonly IBuildingRepository _buildingRepository;

    public RemoveBuildingCommandHandler(IBuildingRepository buildingRepository)
    {
        _buildingRepository = buildingRepository;
    }
    
    public async Task<RemoveBuildingCommandResult> Handle(RemoveBuildingCommand request, CancellationToken cancellationToken)
    {
        var entity = await _buildingRepository.GetAsync(request.Id);
        if(entity==null)
            throw new NotFoundException();
        await _buildingRepository.RemoveAsync(entity);
        var result = new RemoveBuildingCommandResult();
        return result;
    }
}