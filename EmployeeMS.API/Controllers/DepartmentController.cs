using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Queries.GetAllDepartmentsQuery;
using EmployeeMS.Application.Features.Departments.Queries.GetDepartmentByIdQuery;
using EmployeeMS.Application.Features.Departments.Queries.GetDepartmentWithEmployees;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllDepartmentsQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromBody] GetDepartmentByIdQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("employees")]
        public async Task<IActionResult> GetDepartmentWithEmployees([FromQuery] GetDepartmentWithEmployeesQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDepartmentCommand command)
        {
            var id = await mediator.Send(command);
            return Ok(new { DeparmentId = id });
        }

        [HttpPut]
        public async Task<IActionResult> Ubpadte([FromBody] UpdateDepartmentCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteDepartmentCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
