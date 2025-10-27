using EmployeeMS.Shared.Constants;
using EmployeeMS.Shared.LocalizationResources;
using FluentValidation;

namespace EmployeeMS.Application.Features.Employees.Commands.CreateEmployeeCommand
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.FirstName)
                      .NotEmpty().WithMessage(Resource.EmployeeFirstNameRequired)
                      .MaximumLength(ValidationConstants.ShortStringLength).WithMessage(Resource.FirstNameLength);

            RuleFor(x => x.LastName)
                      .NotEmpty().WithMessage(Resource.EmployeeLastNameRequired)
                      .MaximumLength(ValidationConstants.ShortStringLength).WithMessage(Resource.LastNameLength);

            RuleFor(x => x.Email)
                      .NotEmpty().WithMessage(Resource.EmployeeEmailRequired)
                      .MaximumLength(ValidationConstants.ShortStringLength).WithMessage(Resource.EmailLength)
                      .EmailAddress().WithMessage(Resource.EmailFormat); 

            RuleFor(x => x.PhoneNumber)
                      .NotEmpty().WithMessage(Resource.EmployeePhoneNumberRequired)
                      .MaximumLength(ValidationConstants.PhoneNumberLessThan20).WithMessage(Resource.PhoneNumberLength)
                      .Matches(Resource.PhoneNumberFormat).WithMessage(Resource.InvalidPhoneNumberFormat);
            RuleFor(x => x.Salary)
                       .NotNull().WithMessage(Resource.EmployeeSalaryRequired)
                       .GreaterThan(ValidationConstants.IsGreaterThan0).WithMessage(Resource.SalaryLength);

            RuleFor(x => x.DepartmentId)
                      .GreaterThan(ValidationConstants.IsGreaterThan0).WithMessage(Resource.IdIsGreaterThan0);

            RuleFor(x => x.ProfessionId)
                      .GreaterThan(ValidationConstants.IsGreaterThan0).WithMessage(Resource.IdIsGreaterThan0);
        }
    }
}
