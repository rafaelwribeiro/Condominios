using Backend.Application.Contracts;
using Backend.Application.Exceptions;
using Backend.Domain.Repositories;
using Mapster;
using MediatR;

namespace Backend.Application.Commands.GetCondominiumPaymentRanking;

public class GetCondominiumPaymentRankingCommandHandler : IRequestHandler<GetCondominiumPaymentRankingCommand, GetCondominiumPaymentRankingCommandResult>
{
    private readonly IReportRepository _reportRepository;

    public GetCondominiumPaymentRankingCommandHandler(IReportRepository reportRepository)
    {
        _reportRepository = reportRepository;
    }
    
    public async Task<GetCondominiumPaymentRankingCommandResult> Handle(GetCondominiumPaymentRankingCommand request, CancellationToken cancellationToken)
    {
        var list = await _reportRepository.ExecuteStoredProcPaymentRank(request.Contract.start, request.Contract.final);

        var result = new GetCondominiumPaymentRankingCommandResult();
        result.List = list;
        return result;
    }
}