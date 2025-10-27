using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Professions.Commands.DeleteProfessionCommand
{
    public class DeleteProfessionCommandValidator : AbstractValidator<DeleteProfessionCommand>
    {
        public DeleteProfessionCommandValidator()
        {
            RuleFor(x => x.Id)
               .GreaterThan(ValidationConstants.IsGreaterThan0)
               .WithMessage(Resource.IdIsGreaterThan0);
        }
    }
}
