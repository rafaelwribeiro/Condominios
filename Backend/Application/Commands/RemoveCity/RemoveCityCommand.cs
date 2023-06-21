using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.RemoveCity;

public class RemoveCityCommand : IRequest<RemoveCityCommandResult>
{
    public int Id { get; set; }
    public RemoveCityCommand(int id)
    {
        Id = id;
    }
}