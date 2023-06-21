using Backend.Domain.Entities;

namespace Backend.Domain.Repositories;

public interface IApartmentRepository
{
    public Task<Apartment> AddAsync(Apartment apartment);
    public Task RemoveAsync(Apartment apartment);
    public Task UpdateAsync(Apartment apartment);
    public Task<Apartment?> GetAsync(int id);
    public Task<IEnumerable<Apartment>> GetAllAsync(int buildingId);
}