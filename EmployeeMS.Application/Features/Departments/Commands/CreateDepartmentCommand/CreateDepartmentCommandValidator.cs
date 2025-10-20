using FluentValidation;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public class CreateDepartmentCommandValidator : AbstractValidator<CreateDepartmentCommand>
    {
        public CreateDepartmentCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Department name is required")
                .MaximumLength(100).WithMessage("Department name must be less than or equal to 100 charchters");
            
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Department description is required")
                .MaximumLength(300).WithMessage("Department description must be less than or equal to 300 charchters");
        }
    }
}
