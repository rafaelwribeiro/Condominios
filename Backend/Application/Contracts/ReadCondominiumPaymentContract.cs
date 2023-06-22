namespace Backend.Application.Contracts;

public class ReadCondominiumPaymentContract
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal Value { get; set; }
    public int ApartamentId { get; set; }
    public ReadApartmentContract? Apartment { get; set; }
}