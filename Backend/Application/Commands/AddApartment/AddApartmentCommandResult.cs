using Backend.Application.Contracts;

namespace Backend.Application.Commands.AddApartment;

public class AddApartmentCommandResult
{
    public ReadApartmentContract? Apartment { get; set; }
}