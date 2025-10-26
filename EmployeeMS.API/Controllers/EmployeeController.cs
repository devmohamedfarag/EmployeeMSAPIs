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
        public async Task<IActionResult> GetAllEmployees([FromQuery] GetAllEmployeesQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeByID([FromBody] GetEmployeeByIdQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployeeCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(new { EmployeeId = id });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmployee([FromBody] UpdateEmployeeCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee([FromBody] DeleteEmployeeCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
