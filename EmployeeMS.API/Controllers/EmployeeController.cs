using EmployeeMS.Application.Features.Employees.Commands.CreateEmployeeCommand;
using EmployeeMS.Application.Features.Employees.Commands.DeleteEmployeeCommand;
using EmployeeMS.Application.Features.Employees.Commands.UpdateEmployeeCommand;
using EmployeeMS.Application.Features.Employees.Queries.GetAllEmployeesQuery;
using EmployeeMS.Application.Features.Employees.Queries.GetEmployeeByIdQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllEmployeesQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] GetEmployeeByIdQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(new { EmployeeId = id });
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateEmployeeCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteEmployeeCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
