using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public class CreateDepartmentCommandValidator : AbstractValidator<CreateDepartmentCommand>
    {
        public CreateDepartmentCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name Is Required")
                .MaximumLength(100);
            
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Description Is Required")
                .MaximumLength(300);
            
        }
    }
}
