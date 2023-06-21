using Backend.Application.Contracts;

namespace Backend.Application.Commands.GetCity;

public class GetCityCommandResult
{
    public  ReadCityContract? City { get; set; }
}