using EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace EmployeeMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
       private readonly IMediator _mediator;

        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDepartmentCommand command)
        {
            var id = await _mediator.Send(command);

            return Ok(new { DeparmentId = id });
        }
    } 
    
}
