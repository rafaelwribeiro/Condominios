using Backend.Application.Contracts;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.ListApartments;

public class ListCitiesCommandHandler : IRequestHandler<ListApartmentsCommand, ListApartmentsCommandResult>
{
    private readonly IApartmentRepository _apartmentRepository;

    public ListCitiesCommandHandler(IApartmentRepository apartmentRepository)
    {
        _apartmentRepository = apartmentRepository;
    }
    
    public async Task<ListApartmentsCommandResult> Handle(ListApartmentsCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"BuildingId: {request.BuildingId}");
        var list = await _apartmentRepository.GetAllAsync(request.BuildingId);
        Console.WriteLine($"list: {list}");
        if(list == null)
            throw NotFoundException();

        var result = new ListApartmentsCommandResult();
        result.Apartments = list.Adapt<IList<ReadApartmentContract>>();
        return result;
    }

    private Exception NotFoundException()
    {
        throw new NotImplementedException();
    }
}