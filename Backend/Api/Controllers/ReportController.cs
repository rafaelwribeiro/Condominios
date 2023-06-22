using Backend.Application.Commands.AddBuilding;
using Backend.Application.Commands.GetBuilding;
using Backend.Application.Commands.GetCondominiumPaymentRanking;
using Backend.Application.Commands.ListBuildings;
using Backend.Application.Commands.RemoveBuilding;
using Backend.Application.Commands.UpdateBuilding;
using Backend.Application.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ReportController : ControllerBase
{
    private readonly IMediator _mediator;

    public ReportController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("start={start}&finish={finish}")]
    public async Task<IActionResult> GetCondominiumPaymentRanking(DateTime start, DateTime finish)
    {
        CondominiumPaymentRankingContract contract = new CondominiumPaymentRankingContract();
        contract.start = start;
        contract.final = finish;
        var result = await _mediator.Send(new GetCondominiumPaymentRankingCommand(contract));
        return Ok(result.List);
    }

}