using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDepartmentCommand command)
        {
            var id = await mediator.Send(command);

            return Ok(new { DeparmentId = id });
        }
    } 
    
}
