namespace Backend.Application.Contracts;

public class ReadBuildingContract
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Floors { get; set; }
    public ReadCityContract? City { get; set; }
}