using Backend.Domain.Entities;
using Backend.Domain.Repositories;

namespace Backend.Infra.Data.EFCore.Repositories;

public class ApartmentRepository : IApartmentRepository
{
    private readonly EFDbContext _dbContext;

    public ApartmentRepository(EFDbContext dbContext)
        => _dbContext = dbContext;

    public Task<Apartment> AddAsync(Apartment apartment)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Apartment>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Apartment?> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Apartment apartment)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Apartment apartment)
    {
        throw new NotImplementedException();
    }
}