using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.UpdateBuilding;

public class UpdateBuildingCommandHandler : IRequestHandler<UpdateBuildingCommand, UpdateBuildingCommandResult>
{
    private readonly IBuildingRepository _buildingRepository;

    public UpdateBuildingCommandHandler(IBuildingRepository buildingRepository)
    {
        _buildingRepository = buildingRepository;
    }
    
    public async Task<UpdateBuildingCommandResult> Handle(UpdateBuildingCommand request, CancellationToken cancellationToken)
    {
        var entity = await _buildingRepository.GetAsync(request.Contract.Id);

        if(entity==null)
            throw new NotFoundException();

        request.Contract.Adapt(entity);

        await _buildingRepository.UpdateAsync(entity);

        var result = new UpdateBuildingCommandResult();

        return result;
    }
}