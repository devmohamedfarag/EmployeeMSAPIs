using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Professions.Commands.UpadateProfessionCommand
{
    public class UpdateProfessionCommandValidator : AbstractValidator<UpdateProfessionCommand>
    {
        public UpdateProfessionCommandValidator()
        {
            RuleFor(x => x.Title)
               .NotEmpty().WithMessage(Resource.ProfessionTitleRequired)
               .MaximumLength(ValidationConstants.ShortStringLength).WithMessage(Resource.ProfessionTitleLength);

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage(Resource.ProfessionDescriptionRequired)
                .MaximumLength(ValidationConstants.LongStringLength).WithMessage(Resource.ProfessionDescriptionLength);

            RuleFor(x => x.AcceptedSalary)
                .NotEmpty().WithMessage(Resource.ProfessionAcceptedSalaryIsrequired);
        }
    }
}
