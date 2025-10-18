using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public class CreateDepartmentCommand : IRequest<int>
    {
        public string Name {  get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
