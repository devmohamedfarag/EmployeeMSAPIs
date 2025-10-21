using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand;
using EmployeeMS.Application.Features.Departments.Queries.GetAllDepartmentsQuery;
using EmployeeMS.Application.Features.Departments.Queries.GetDepartmentByIdQuery;
using EmployeeMS.Shared.LocalizationResources;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllDepartments([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var query = new GetAllDepartmentsQuery(pageNumber, pageSize);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var query = new GetDepartmentByIdQuery(id);
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
        public async Task<IActionResult>UbpadteDepartment(int id, UpdateDepartmentCommand command)
        {
            if (id != command.Id) 
            {
                return BadRequest(Resource.DepatrmentIdNotMatch);
            }

            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var result = await mediator.Send( new DeleteDepartmentCommand(id));

            return Ok(result);
        }
    } 
}
