using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand
{
    public class DeleteDepartmentCommandValidator : AbstractValidator<DeleteDepartmentCommand>
    {
        public DeleteDepartmentCommandValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(ValidationConstants.IdIsGreaterThan0)
                .WithMessage(Resource.IdIsGreaterThan0);
        }
    }
}
