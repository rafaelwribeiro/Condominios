namespace Backend.Domain.Entities;

public class Apartament
{
    public int Id { get; set; }
    public int BuildingId { get; set; }
    public Building Building { get; set; }
    public int Floor { get; set; }
    public int BadroomsQuantity { get; set; }
}