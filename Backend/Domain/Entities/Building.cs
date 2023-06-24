namespace Backend.Domain.Entities;

public class Building
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Floors { get; set; }
    public int CityId { get; set; }
    public City? City { get; set; }
    public IList<Apartment> Apartments { get; set; } = new List<Apartment>();

    public void AddApartament(Apartment app) => Apartments.Add(app);
}