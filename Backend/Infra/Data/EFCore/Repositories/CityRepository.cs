using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infra.Data.EFCore.Repositories;

public class CityRepository : ICityRepository
{
    private readonly EFDbContext _dbContext;
    public CityRepository(EFDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<City> AddAsync(City city)
    {
        await _dbContext.Cities.AddAsync(city);
        await _dbContext.SaveChangesAsync();
        return city;
    }

    public async Task<IEnumerable<City>> GetAllAsync()
    {
        return await _dbContext.Cities.AsNoTracking().ToListAsync();
    }

    public async Task<City?> GetAsync(int id)
    {
        return await _dbContext.Cities.Where(c => c.Id == id).FirstOrDefaultAsync();
    }

    public async Task RemoveAsync(City city)
    {
        _dbContext.Cities.Remove(city);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(City city)
    {
        _dbContext.Cities.Update(city);
        await _dbContext.SaveChangesAsync();
    }
}