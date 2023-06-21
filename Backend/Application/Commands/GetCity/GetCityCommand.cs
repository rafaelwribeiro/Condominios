using MediatR;

namespace Backend.Application.Commands.GetCity;

public class GetCityCommand : IRequest<GetCityCommandResult>
{
    public int Id { get; set; }
    public GetCityCommand(int id)
    {
        Id = id;
    }
}