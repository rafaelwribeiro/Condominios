using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.AddCity;

public class AddCityCommand : IRequest<AddCityCommandResult>
{
    public CreateCityContract Contract { get; set; }
    public AddCityCommand(CreateCityContract contract)
    {
        Contract = contract;
    }
}