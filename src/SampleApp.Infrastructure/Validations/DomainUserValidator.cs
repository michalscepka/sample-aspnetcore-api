using FluentValidation;
using SampleApp.Domain;

namespace SampleApp.Infrastructure.Validations;

public class DomainUserValidator : AbstractValidator<User>
{
    public DomainUserValidator()
    {
        RuleFor(x => x.Id)
            .NotEmpty();

        RuleFor(x => x.FirstName)
            .NotEmpty();

        RuleFor(x => x.LastName)
            .NotEmpty();

        RuleFor(x => x.YearOfBirth)
            .LessThanOrEqualTo((ushort)Math.Min(DateTime.UtcNow.Year, ushort.MaxValue));
    }
}
