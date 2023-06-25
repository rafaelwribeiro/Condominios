using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.UpdateCondominiumPayment;

public class UpdateCondominiumPaymentCommand : IRequest<UpdateCondominiumPaymentCommandResult>
{
    public UpdateCondominiumPaymentContract Contract { get; set; }
    public UpdateCondominiumPaymentCommand(UpdateCondominiumPaymentContract contract)
    {
        Contract = contract;
    }
}