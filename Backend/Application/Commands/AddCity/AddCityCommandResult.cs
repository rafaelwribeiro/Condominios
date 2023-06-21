using Backend.Application.Contracts;

namespace Backend.Application.Commands.AddCity;

public class AddCityCommandResult
{
    public ReadCityContract? City { get; set; }
}