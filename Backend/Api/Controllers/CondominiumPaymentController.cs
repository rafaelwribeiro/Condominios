using Backend.Application.Commands.AddCondominiumPayment;
using Backend.Application.Commands.GetCondominiumPaymentRanking;
using Backend.Application.Commands.ListPayments;
using Backend.Application.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers;

[ApiController]
[Route("buildings/{buildingId}/Apartments/{apartmentId}/[controller]")]
public class CondominiumPaymentsController : ControllerBase
{
    private readonly IMediator _mediator;

    public CondominiumPaymentsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(int buildingId, int apartmentId)
    {
        var result = await _mediator.Send(new ListPaymentsCommand(buildingId, apartmentId));
        return Ok(result.Payments);
    }

    [HttpPost]
    public async Task<IActionResult> Post(int buildingId, int apartmentId, CreateCondominiumPaymentContract contract)
    {
        var result = await _mediator.Send(new AddCondominiumPaymentCommand(buildingId, apartmentId, contract));
        return Ok(result.Payment);
    }
    
}