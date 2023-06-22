using Backend.Application.Contracts;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.AddCondominiumPayment;

public class AddCondominiumPaymentCommandHandler : IRequestHandler<AddCondominiumPaymentCommand, AddCondominiumPaymentCommandResult>
{
    private readonly ICondominiumPaymentRepository _condominiumPaymentRepository;

    public AddCondominiumPaymentCommandHandler(ICondominiumPaymentRepository condominiumPaymentRepository)
    {
        _condominiumPaymentRepository = condominiumPaymentRepository;
    }
    
    public async Task<AddCondominiumPaymentCommandResult> Handle(AddCondominiumPaymentCommand request, CancellationToken cancellationToken)
    {
        var entity = request.Contract.Adapt<CondominiumPayment>();
        entity.ApartamentId = request.ApartamentId;

        var createdEntity = await _condominiumPaymentRepository.AddAsync(entity);

        var result = new AddCondominiumPaymentCommandResult();
        result.Payment = createdEntity.Adapt<ReadCondominiumPaymentContract>();
        return result;
    }
}