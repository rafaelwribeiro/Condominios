namespace Backend.Application.Contracts;

public class ReadPaymentContract
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public decimal Value { get; set; }
    public int ApartmentId { get; set; }
    public ReadApartmentContract Apartment { get; set; }
}