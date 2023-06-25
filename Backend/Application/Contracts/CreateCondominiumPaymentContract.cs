namespace Backend.Application.Contracts;

public class CreateCondominiumPaymentContract
{
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public decimal Value { get; set; }
}