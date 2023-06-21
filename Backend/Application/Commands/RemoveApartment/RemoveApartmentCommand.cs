using MediatR;

namespace Backend.Application.Commands.RemoveApartment;

public class RemoveApartmentCommand : IRequest<RemoveApartmentCommandResult>
{
    public int Id { get; set; }
    public RemoveApartmentCommand(int id)
    {
        Id = id;
    }
}