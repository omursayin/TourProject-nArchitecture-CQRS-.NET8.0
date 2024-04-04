using FluentValidation;

namespace Application.Features.Contacts.Commands.Create;

public class CreateContactCommandValidator : AbstractValidator<CreateContactCommand>
{
    public CreateContactCommandValidator()
    {
        RuleFor(c => c.Address).NotEmpty();
        RuleFor(c => c.Phone).NotEmpty();
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.Website).NotEmpty();
        RuleFor(c => c.MapLocation).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
    }
}