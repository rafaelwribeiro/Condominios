using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.AddCondominiumPayment;

public class AddCondominiumPaymentCommand : IRequest<AddCondominiumPaymentCommandResult>
{
    public int ApartamentId { get; set; }
    public CreateCondominiumPaymentContract Contract { get; set; }
    public AddCondominiumPaymentCommand(int apartamentId, CreateCondominiumPaymentContract contract)
    {
        ApartamentId = apartamentId;
        Contract = contract;
    }
}