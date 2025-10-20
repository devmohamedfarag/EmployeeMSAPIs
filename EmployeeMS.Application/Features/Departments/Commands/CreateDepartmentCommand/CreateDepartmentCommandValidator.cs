using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Departments.Commands.CreateDepartmentCommand
{
    public class CreateDepartmentCommandValidator : AbstractValidator<CreateDepartmentCommand>
    {
        public CreateDepartmentCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(Resource.DepartmentNameRequired)
                .MaximumLength(ValidationConstants.ShortStringLength).WithMessage(Resource.DepartmentNameLength);
            
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage(Resource.DeparmentDescriptionRequired)
                .MaximumLength(ValidationConstants.LongStringLength).WithMessage(Resource.DepartmentDescriptionLength);
        }
    }
}
