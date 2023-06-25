using Backend.Application.Contracts;

using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.ListPayments;

public class ListPaymentsCommandHandler : IRequestHandler<ListPaymentsCommand, ListPaymentsCommandResult>
{
    private readonly ICondominiumPaymentRepository _paymentRepository;

    public ListPaymentsCommandHandler(ICondominiumPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }
    
    public async Task<ListPaymentsCommandResult> Handle(ListPaymentsCommand request, CancellationToken cancellationToken)
    {
        var cities = await _paymentRepository.GetAllAsync(request.ApartmentId);

        var result = new ListPaymentsCommandResult();
        result.Payments = cities.Adapt<IList<ReadPaymentContract>>();
        return result;
    }
}