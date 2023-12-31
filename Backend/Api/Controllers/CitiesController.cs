using Backend.Application.Commands.AddCity;
using Backend.Application.Commands.GetCity;
using Backend.Application.Commands.ListCities;
using Backend.Application.Commands.RemoveCity;
using Backend.Application.Commands.UpdateCity;
using Backend.Application.Contracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class CitiesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CitiesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}", Name = "CityDetails")]
    public async Task<IActionResult> Get(int id)
    {
        var result = await _mediator.Send(new GetCityCommand(id));
        var city = result.City;
        return Ok(city);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var list = await _mediator.Send(new ListCitiesCommand());
        return Ok(list.Cities);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateCityContract contract)
    {
        var result = await _mediator.Send(new AddCityCommand(contract));
        var city = result.City;
        return CreatedAtRoute("CityDetails", new { Id = city?.Id }, city);
    }

    [HttpPut]
    public async Task<IActionResult> Update(UpdateCityContract contract)
    {
        var result = await _mediator.Send(new UpdateCityCommand(contract));
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await _mediator.Send(new RemoveCityCommand(id));
        return NoContent();
    }
}