namespace Backend.Application.Contracts;

public class ReadApartmentContract
{
    public int Id { get; set; }
    public int Floor { get; set; }
    public int BadroomsQuantity { get; set; }
    public decimal SizeM2 { get; set; }
    public int BuildingId { get; set; }
    public ReadBuildingWithOutApartmentContract Building { get; set; }
}