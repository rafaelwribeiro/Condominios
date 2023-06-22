namespace Backend.Domain.Entities;

public class CondominiumPayment
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public decimal Value { get; set; }
    public int ApartamentId { get; set; }
    public Apartment? Apartment { get; set; }
}