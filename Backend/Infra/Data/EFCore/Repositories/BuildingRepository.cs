using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infra.Data.EFCore.Repositories;

public class BuildingRepository : IBuildingRepository
{
    private readonly EFDbContext _dbContext;

    public BuildingRepository(EFDbContext dbContext)
        => _dbContext = dbContext;

    public async Task<Building> AddAsync(Building building)
    {
        await _dbContext.Buildings.AddAsync(building);
        await _dbContext.SaveChangesAsync();
        return building;
    }

    public async Task<IEnumerable<Building>> GetAllAsync()
    {
        return await _dbContext
            .Buildings
            .Include(b => b.City)
            .Include(b => b.Apartments)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Building?> GetAsync(int id)
    {
        return await _dbContext
            .Buildings
            .Include(b => b.City)
            .Include(b => b.Apartments)
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();
    }

    public async Task RemoveAsync(Building building)
    {
        _dbContext.Buildings.Remove(building);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Building building)
    {
        _dbContext.Buildings.Update(building);
        await _dbContext.SaveChangesAsync();
    }
}