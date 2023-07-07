using Backend.Application.Contracts;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Backend.Application.Interfaces;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.AddApartment;

public class AddApartmentCommandHandler : IRequestHandler<AddApartmentCommand, AddApartmentCommandResult>
{
    private readonly IApartmentRepository _apartmentRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddApartmentCommandHandler(IApartmentRepository apartmentRepository, IUnitOfWork unitOfWork)
    {
        _apartmentRepository = apartmentRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<AddApartmentCommandResult> Handle(AddApartmentCommand request, CancellationToken cancellationToken)
    {

        var entity = request.Contract.Adapt<Apartment>();
        entity.BuildingId = request.BuildingId;
        var building = await _apartmentRepository.AddAsync(entity);
        var result = new AddApartmentCommandResult();
        result.Apartment = building.Adapt<ReadApartmentContract>();
        await _unitOfWork.CommitAsync();
        return result;
    }
}