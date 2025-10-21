using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Departments.Commands.UpdateDepartmentCommand
{
    public class UpdateDepartmentCommandValidator : AbstractValidator<UpdateDepartmentCommand>
    {
        public UpdateDepartmentCommandValidator()
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
