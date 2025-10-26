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
        public async Task<IActionResult> GetAllProfessions([FromQuery] GetAllProfessionsQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfessionById([FromBody] GetProfessionByIdQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProfession([FromBody] CreateProfessionCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(new { ProfessionId = id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpadteProfession([FromBody] UpdateProfessionCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfession([FromBody] DeleteProfessionCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
