namespace Backend.Application.Contracts;

public class ReadBuildingContract
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Floors { get; set; }
    public int CityId { get; set; }
    public ReadCityContract? City { get; set; }
    public IEnumerable<ReadApartmentContract> Apartments { get ; set; } = Enumerable.Empty<ReadApartmentContract>();
}