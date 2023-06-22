using Backend.Application.Commands.GetCondominiumPaymentRanking;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers;

[ApiController]
[Route("Buildings/{buildingId}/Apartment/{apartmentId}/[controller]")]
public class CondominiumPaymentController : ControllerBase
{
    private readonly IMediator _mediator;

    public CondominiumPaymentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(int buildingId, int apartmentId)
    {
        return Ok("");
    }
    
}