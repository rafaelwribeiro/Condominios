using Backend.Domain.Report;

namespace Backend.Domain.Repositories;

public interface IReportRepository
{
    public Task<IList<CondominiumPaymentRankingReport>> ExecuteStoredProcPaymentRank(DateTime startDate, DateTime finalDate);
}