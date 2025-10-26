using EmployeeMS.Application.Features.Professions.Commands.CreateProfessionCommand;
using EmployeeMS.Application.Features.Professions.Commands.DeleteProfessionCommand;
using EmployeeMS.Application.Features.Professions.Commands.UpadateProfessionCommand;
using EmployeeMS.Application.Features.Professions.Queries.GetAllProfessionsQuery;
using EmployeeMS.Application.Features.Professions.Queries.GetProfessionByIdQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessionController(IMediator mediator) : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllProfessionsQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromBody] GetProfessionByIdQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProfessionCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(new { ProfessionId = id });
        }

        [HttpPut]
        public async Task<IActionResult> Upadte([FromBody] UpdateProfessionCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteProfessionCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
