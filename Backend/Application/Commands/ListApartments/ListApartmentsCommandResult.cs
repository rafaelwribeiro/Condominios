using Backend.Application.Contracts;

namespace Backend.Application.Commands.ListApartments;

public class ListApartmentsCommandResult
{
    public IList<ReadApartmentContract> Apartments { get; set; } = new List<ReadApartmentContract>();
}