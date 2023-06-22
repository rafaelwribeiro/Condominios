using Backend.Domain.Report;
using Backend.Domain.Repositories;

namespace Backend.Infra.Data.EFCore.Repositories;

public class ReportRepository : IReportRepository
{
    private readonly EFDbContext _dbContext;
    public ReportRepository(EFDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IList<CondominiumPaymentRankingReport>> ExecuteStoredProcPaymentRank(DateTime startDate, DateTime finalDate)
    {
        return await _dbContext.ExecuteStoredProcPaymentRank(startDate, finalDate);
    }
}