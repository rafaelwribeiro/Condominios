using MediatR;

namespace Backend.Application.Commands.ListApartments;

public class ListApartmentsCommand : IRequest<ListApartmentsCommandResult>
{
    public int BuildingId { get; set; }

    public ListApartmentsCommand(int buildingId)
    {
        BuildingId = buildingId;
    }
}