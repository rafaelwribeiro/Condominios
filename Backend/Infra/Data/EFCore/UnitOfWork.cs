using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Application.Interfaces;

namespace Backend.Infra.Data.EFCore;

public class UnitOfWork : IUnitOfWork
{
    private readonly EFDbContext _dbContext;

    public UnitOfWork(EFDbContext dbContext)
        => _dbContext = dbContext;

    public async Task CommitAsync()
    {
        await _dbContext.SaveChangesAsync();
    }

    public Task Rollback()
    {
        return Task.CompletedTask;
    }
}