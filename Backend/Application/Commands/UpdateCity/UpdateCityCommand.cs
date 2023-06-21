using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.UpdateCity;

public class UpdateCityCommand : IRequest<UpdateCityCommandResult>
{
    public UpdateCityContract Contract { get; set; }
    public UpdateCityCommand(UpdateCityContract contract)
    {
        Contract = contract;
    }
}