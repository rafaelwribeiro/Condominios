using Backend.Application.Contracts;
using Backend.Application.Exceptions;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.RemovePayment;

public class RemovePaymentCommandHandler : IRequestHandler<RemovePaymentCommand, RemovePaymentCommandResult>
{
    private readonly ICondominiumPaymentRepository _paymentRepository;

    public RemovePaymentCommandHandler(ICondominiumPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }
    
    public async Task<RemovePaymentCommandResult> Handle(RemovePaymentCommand request, CancellationToken cancellationToken)
    {
        var payment = await _paymentRepository.GetAsync(request.Id);
        if(payment==null)
            throw new NotFoundException();
        await _paymentRepository.RemoveAsync(payment);
        var result = new RemovePaymentCommandResult();
        return result;
    }
}