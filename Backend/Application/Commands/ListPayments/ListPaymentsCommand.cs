using MediatR;

namespace Backend.Application.Commands.ListPayments;

public class ListPaymentsCommand : IRequest<ListPaymentsCommandResult>
{
    public int BuildingId { get; set; }
    public int ApartmentId { get; set; }

    public ListPaymentsCommand(int buildingId, int apartmentId)
    {
        BuildingId = buildingId;
        ApartmentId = apartmentId;
    }
}