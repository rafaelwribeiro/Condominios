using Backend.Application.Commands.AddBuilding;
using Backend.Application.Commands.GetBuilding;
using Backend.Application.Commands.ListBuildings;
using Backend.Application.Commands.RemoveBuilding;
using Backend.Application.Commands.UpdateBuilding;
using Backend.Application.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class BuildingsController : ControllerBase
{
    private readonly IMediator _mediator;

    public BuildingsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}", Name = "BuildingDetails")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _mediator.Send(new GetBuildingCommand(id));
        var building = result.Building;
        return Ok(building);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _mediator.Send(new ListBuildingsCommand());
        return Ok(result.Buildings);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateBuildingContract contract)
    {
        var result = await _mediator.Send(new AddBuildingCommand(contract));
        var building = result.Building;
        return CreatedAtRoute("BuildingDetails", new { Id = building?.Id }, building);
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateBuildingContract contract)
    {
        var result = await _mediator.Send(new UpdateBuildingCommand(contract));
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new RemoveBuildingCommand(id));
        return NoContent();
    }
}