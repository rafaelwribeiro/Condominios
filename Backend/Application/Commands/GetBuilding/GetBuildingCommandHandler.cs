using Backend.Application.Contracts;
using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.GetBuilding;

public class GetBuildingCommandHandler : IRequestHandler<GetBuildingCommand, GetBuildingCommandResult>
{
    private readonly IBuildingRepository _buldingRepository;

    public GetBuildingCommandHandler(IBuildingRepository buldingRepository)
    {
        _buldingRepository = buldingRepository;
    }
    
    public async Task<GetBuildingCommandResult> Handle(GetBuildingCommand request, CancellationToken cancellationToken)
    {
        var entity = await _buldingRepository.GetAsync(request.Id);

        if(entity == null)
            throw new NotFoundException();

        var result = new GetBuildingCommandResult();
        result.Building = entity.Adapt<ReadBuildingContract>();
        return result;
    }
}