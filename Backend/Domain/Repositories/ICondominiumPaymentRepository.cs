using Backend.Domain.Entities;

namespace Backend.Domain.Repositories;

public interface ICondominiumPaymentRepository
{
    public Task<CondominiumPayment> AddAsync(CondominiumPayment entity);
    public Task RemoveAsync(CondominiumPayment entity);
    public Task UpdateAsync(CondominiumPayment entity);
    public Task<CondominiumPayment?> GetAsync(int id);
    public Task<IEnumerable<CondominiumPayment>> GetAllAsync(int apartmentId);
}