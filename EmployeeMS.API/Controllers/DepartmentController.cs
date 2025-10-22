using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Queries.GetAllDepartmentsQuery;
using EmployeeMS.Application.Features.Departments.Queries.GetDepartmentByIdQuery;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments([FromQuery] GetAllDepartmentsQuery query)
        {
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentById([FromRoute] GetDepartmentByIdQuery query)
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

        [HttpPut("{id}")]
        public async Task<IActionResult>UbpadteDepartment([FromBody]UpdateDepartmentCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment([FromRoute] DeleteDepartmentCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    } 
}
