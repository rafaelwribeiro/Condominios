using Backend.Application.Contracts;
using Backend.Domain.Report;

namespace Backend.Application.Commands.GetCondominiumPaymentRanking;

public class GetCondominiumPaymentRankingCommandResult
{
    public  IList<CondominiumPaymentRankingReport> List { get; set; }
}