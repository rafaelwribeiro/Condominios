using Backend.Domain.Entities;

namespace Backend.Domain.Repositories;

public interface IBuildingRepository
{
    public Task<Building> AddAsync(Building building);
    public Task RemoveAsync(Building building);
    public Task UpdateAsync(Building building);
    public Task<Building?> GetAsync(int id);
    public Task<IEnumerable<Building>> GetAllAsync();
}