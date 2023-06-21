using Backend.Domain.Entities;
using Backend.Domain.Repositories;

namespace Backend.Infra.Data.EFCore.Repositories;

public class BuildingRepository : IBuildingRepository
{
    private readonly EFDbContext _dbContext;

    public BuildingRepository(EFDbContext dbContext)
        => _dbContext = dbContext;

    public Task<Building> AddAsync(Building building)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Building>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Building?> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Building building)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Building building)
    {
        throw new NotImplementedException();
    }
}