using Backend.Domain.Entities;

namespace Backend.Domain.Repositories;

public interface ICityRepository
{
    public Task<City> AddAsync(City city);
    public Task RemoveAsync(City city);
    public Task UpdateAsync(City city);
    public Task<City?> GetAsync(int id);
    public Task<IEnumerable<City>> GetAllAsync();
}