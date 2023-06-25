namespace Backend.Application.Contracts;

public class CreateApartmentContract
{
    public int Floor { get; set; }
    public int BadroomsQuantity { get; set; }
    public decimal SizeM2 { get; set; }
}