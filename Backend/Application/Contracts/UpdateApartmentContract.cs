namespace Backend.Application.Contracts;

public class UpdateApartmentContract
{
    public int Id { get; set; }
    public int Floor { get; set; }
    public int BadroomsQuantity { get; set; }
    public decimal SizeM2 { get; set; }
}