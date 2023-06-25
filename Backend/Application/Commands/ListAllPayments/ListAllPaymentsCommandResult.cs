using Backend.Application.Contracts;

namespace Backend.Application.Commands.ListAllPayments;

public class ListAllPaymentsCommandResult
{
    public IList<ReadPaymentContract> Payments { get; set; } = Enumerable.Empty<ReadPaymentContract>().ToList();
}