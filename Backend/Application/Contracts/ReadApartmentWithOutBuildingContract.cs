namespace Backend.Application.Contracts;

public class ReadApartmentWithOutBuildingContract
{
    public int Id { get; set; }
    public int Floor { get; set; }
    public int BadroomsQuantity { get; set; }
    public int BuildingId { get; set; }
}