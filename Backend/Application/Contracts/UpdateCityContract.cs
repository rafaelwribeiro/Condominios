namespace Backend.Application.Contracts;

public class UpdateCityContract
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string State { get; set; } = "";
}