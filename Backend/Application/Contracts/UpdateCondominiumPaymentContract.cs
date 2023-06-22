namespace Backend.Application.Contracts;

public class UpdateCondominiumPaymentContract
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal Value { get; set; }
}