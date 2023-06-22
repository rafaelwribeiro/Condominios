using Backend.Application.Contracts;

namespace Backend.Application.Commands.AddCondominiumPayment;

public class AddCondominiumPaymentCommandResult
{
    public ReadCondominiumPaymentContract? Payment { get; set; }
}