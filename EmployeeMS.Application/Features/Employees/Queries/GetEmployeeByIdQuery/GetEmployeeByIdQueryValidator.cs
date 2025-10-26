using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Employees.Queries.GetEmployeeByIdQuery
{
    public class GetEmployeeByIdQueryValidator : AbstractValidator<GetEmployeeByIdQuery>
    {
        public GetEmployeeByIdQueryValidator()
        {
            RuleFor(x => x.Id)
              .GreaterThan(ValidationConstants.IsGreaterThan0)
              .WithMessage(Resource.IdIsGreaterThan0);
        }
    }
}
