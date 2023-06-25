using Backend.Application.Contracts;

namespace Backend.Application.Commands.ListPayments;

public class ListPaymentsCommandResult
{
    public IList<ReadPaymentContract> Payments { get; set; } = Enumerable.Empty<ReadPaymentContract>().ToList();
}