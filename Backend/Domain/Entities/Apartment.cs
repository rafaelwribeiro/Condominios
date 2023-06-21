namespace Backend.Domain.Entities;

public class Apartment
{
    public int Id { get; set; }
    public int BuildingId { get; set; }
    public Building? Building { get; set; }
    public int Floor { get; set; }
    public int BadroomsQuantity { get; set; }
}