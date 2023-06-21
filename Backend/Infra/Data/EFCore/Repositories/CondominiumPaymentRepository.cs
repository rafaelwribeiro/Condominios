using Backend.Domain.Entities;
using Backend.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Backend.Infra.Data.EFCore.Repositories;

public class CondominiumPaymentRepository : ICondominiumPaymentRepository
{
    private readonly EFDbContext _dbContext;
    public CondominiumPaymentRepository(EFDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<CondominiumPayment> AddAsync(CondominiumPayment entity)
    {
        await _dbContext.CondominiumPayments.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<CondominiumPayment>> GetAllAsync(int apartmentId)
    {
        return await _dbContext
            .CondominiumPayments
            .Include(a => a.Apartment)
            .Where(a => a.ApartamentId == apartmentId)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<CondominiumPayment?> GetAsync(int id)
    {
        return await _dbContext
            .CondominiumPayments
            .Include(b => b.Apartment)
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();
    }

    public async Task RemoveAsync(CondominiumPayment entity)
    {
        _dbContext.CondominiumPayments.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(CondominiumPayment entity)
    {
        _dbContext.CondominiumPayments.Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}