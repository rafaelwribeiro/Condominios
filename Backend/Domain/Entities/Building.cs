using System.Collections.Generic;

namespace Backend.Domain.Entities;

public class Building
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Floors { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
    public IList<Apartament> Apartaments { get; set; } = new List<Apartament>();

    public void AddApartament(Apartament app) => Apartaments.Add(app);
}