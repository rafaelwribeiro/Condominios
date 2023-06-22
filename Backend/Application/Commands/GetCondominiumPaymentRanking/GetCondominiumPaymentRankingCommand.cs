using Backend.Application.Contracts;
using MediatR;

namespace Backend.Application.Commands.GetCondominiumPaymentRanking;

public class GetCondominiumPaymentRankingCommand : IRequest<GetCondominiumPaymentRankingCommandResult>
{
    public CondominiumPaymentRankingContract Contract { get; set; }

    public GetCondominiumPaymentRankingCommand(CondominiumPaymentRankingContract contract)
    {
        Contract = contract;
    }
}