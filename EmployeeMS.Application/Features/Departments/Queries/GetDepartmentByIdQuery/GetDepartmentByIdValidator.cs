using EmployeeMS.Application.Features.Departments.Commands.DeleteDepartmentCommand;
using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Departments.Queries.GetDepartmentByIdQuery
{
    public class GetDepartmentByIdValidator : AbstractValidator<DeleteDepartmentCommand>
    {
        public GetDepartmentByIdValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(ValidationConstants.IdIsGreaterThan0)
                .WithMessage(Resource.IdIsGreaterThan0);
        }
    }
}
