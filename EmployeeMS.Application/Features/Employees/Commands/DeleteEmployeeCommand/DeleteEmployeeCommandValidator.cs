using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Employees.Commands.DeleteEmployeeCommand
{
    public class DeleteEmployeeCommandValidator : AbstractValidator<DeleteEmployeeCommand>
    {
        public DeleteEmployeeCommandValidator()
        {
            RuleFor(x => x.Id)
              .GreaterThan(ValidationConstants.IsGreaterThan0)
              .WithMessage(Resource.IdIsGreaterThan0);
        }
    }
}
