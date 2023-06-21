using Backend.Application.Contracts;

namespace Backend.Application.Commands.GetApartment;

public class GetApartmentCommandResult
{
    public  ReadApartmentContract? Apartment { get; set; }
}