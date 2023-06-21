namespace Backend.Application.Contracts;

public class CreateApartmentContract
{
    public int Id { get; set; }
    public int BuildingId { get; set; }
    public int Floor { get; set; }
    public int BadroomsQuantity { get; set; }
}