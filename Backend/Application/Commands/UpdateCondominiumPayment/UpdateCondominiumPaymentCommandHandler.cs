using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.UpdateCondominiumPayment;

public class UpdateCondominiumPaymentCommandHandler : IRequestHandler<UpdateCondominiumPaymentCommand, UpdateCondominiumPaymentCommandResult>
{
    private readonly ICondominiumPaymentRepository _paymentRepository;

    public UpdateCondominiumPaymentCommandHandler(ICondominiumPaymentRepository paymentRepository)
    {
        _paymentRepository = paymentRepository;
    }
    
    public async Task<UpdateCondominiumPaymentCommandResult> Handle(UpdateCondominiumPaymentCommand request, CancellationToken cancellationToken)
    {
        var payment = await _paymentRepository.GetAsync(request.Contract.Id);

        if(payment==null)
            throw new NotFoundException();

        request.Contract.Adapt(payment);

        await _paymentRepository.UpdateAsync(payment);

        var result = new UpdateCondominiumPaymentCommandResult();

        return result;
    }
}