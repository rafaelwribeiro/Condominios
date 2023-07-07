using System.Threading.Tasks;
using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infra.Data.EFCore.Repositories;

public class ApartmentRepository : IApartmentRepository
{
    private readonly EFDbContext _dbContext;

    public ApartmentRepository(EFDbContext dbContext)
        => _dbContext = dbContext;

    public async Task<Apartment> AddAsync(Apartment apartment)
    {
        await _dbContext.Apartaments.AddAsync(apartment);
        return apartment;
    }

    public async Task<IEnumerable<Apartment>> GetAllAsync(int buildingId)
    {
        return await _dbContext
            .Apartaments
            .Include(a => a.Building)
                .ThenInclude(b => b.City)
            .Where(a => a.BuildingId == buildingId)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Apartment?> GetAsync(int id)
    {
        return await _dbContext
            .Apartaments
            .Include(b => b.Building)
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();
    }

    public Task RemoveAsync(Apartment apartment)
    {
        _dbContext.Apartaments.Remove(apartment);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Apartment apartment)
    {
        _dbContext.Apartaments.Update(apartment);
        return Task.CompletedTask;
    }
}