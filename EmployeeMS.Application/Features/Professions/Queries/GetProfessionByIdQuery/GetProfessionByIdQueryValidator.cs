using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Professions.Queries.GetProfessionByIdQuery
{
    public class GetProfessionByIdQueryValidator : AbstractValidator<GetProfessionByIdQuery>
    {
        public GetProfessionByIdQueryValidator()
        {
            RuleFor(x => x.Id)
               .GreaterThan(ValidationConstants.IsGreaterThan0)
               .WithMessage(Resource.IdIsGreaterThan0);
        }
    }
}
