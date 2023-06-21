namespace Backend.Application.Contracts;

public class CreateBuildingContract
{
    public string Name { get; set; } = "";
    public int Floors { get; set; }
    public int CityId { get; set; }
}