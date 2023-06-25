using MediatR;

namespace Backend.Application.Commands.RemovePayment;

public class RemovePaymentCommand : IRequest<RemovePaymentCommandResult>
{
    public int Id { get; set; }
    public RemovePaymentCommand(int id)
    {
        Id = id;
    }
}