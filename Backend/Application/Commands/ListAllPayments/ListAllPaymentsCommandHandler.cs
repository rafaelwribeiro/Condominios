using Backend.Application.Contracts;

using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.ListAllPayments;

public class ListAllPaymentsCommandHandler : IRequestHandler<ListAllPaymentsCommand, ListAllPaymentsCommandResult>
{
    private readonly ICondominiumPaymentRepository _paymentRepository;

    public ListAllPaymentsCommandHandler(ICondominiumPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }
    
    public async Task<ListAllPaymentsCommandResult> Handle(ListAllPaymentsCommand request, CancellationToken cancellationToken)
    {
        var payments = await _paymentRepository.GetAllAsync();

        var result = new ListAllPaymentsCommandResult();
        result.Payments = payments.Adapt<IList<ReadPaymentContract>>();
        return result;
    }
}