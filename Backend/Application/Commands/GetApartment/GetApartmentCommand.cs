using MediatR;

namespace Backend.Application.Commands.GetApartment;

public class GetApartmentCommand : IRequest<GetApartmentCommandResult>
{
    public int Id { get; set; }
    public GetApartmentCommand(int id)
    {
        Id = id;
    }
}