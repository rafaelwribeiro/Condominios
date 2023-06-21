using Backend.Application.Commands.AddApartment;
using Backend.Application.Commands.AddBuilding;
using Backend.Application.Commands.GetApartment;
using Backend.Application.Commands.GetBuilding;
using Backend.Application.Commands.ListApartments;
using Backend.Application.Commands.ListBuildings;
using Backend.Application.Commands.RemoveApartment;
using Backend.Application.Commands.RemoveBuilding;
using Backend.Application.Commands.UpdateApartment;
using Backend.Application.Commands.UpdateBuilding;
using Backend.Application.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers;

[ApiController]
[Route("buildings/{buildingId}/[controller]")]
public class ApartmentController : ControllerBase
{
    private readonly IMediator _mediator;

    public ApartmentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}", Name = "ApartmentDetails")]
    public async Task<IActionResult> Get(int buildingId, int id)
    {
        var result = await _mediator.Send(new GetApartmentCommand(id));
        var apartment = result.Apartment;
        return Ok(apartment);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(int buildingId)
    {
        var result = await _mediator.Send(new ListApartmentsCommand(buildingId));
        return Ok(result.Apartments);
    }

    [HttpPost]
    public async Task<IActionResult> Create(int buildingId, CreateApartmentContract contract)
    {
        var result = await _mediator.Send(new AddApartmentCommand(contract));
        var apartment = result.Apartment;
        return CreatedAtRoute("ApartmentDetails", new { Id = apartment?.Id }, apartment);
    }

    [HttpPut]
    public async Task<IActionResult> Update(int buildingId, UpdateApartmentContract contract)
    {
        var result = await _mediator.Send(new UpdateApartmentCommand(contract));
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int buildingId, int id)
    {
        var result = await _mediator.Send(new RemoveApartmentCommand(id));
        return NoContent();
    }
}