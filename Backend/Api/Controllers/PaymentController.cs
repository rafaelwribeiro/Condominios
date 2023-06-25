using Backend.Application.Commands.ListAllPayments;
using Backend.Application.Commands.RemovePayment;
using Backend.Application.Commands.UpdateCondominiumPayment;
using Backend.Application.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly IMediator _mediator;

    public PaymentsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new ListAllPaymentsCommand());
        return Ok(result.Payments);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _mediator.Send(new RemovePaymentCommand(id));
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCondominiumPaymentContract contract)
    {
        await _mediator.Send(new UpdateCondominiumPaymentCommand(contract));
        return NoContent();
    }
}