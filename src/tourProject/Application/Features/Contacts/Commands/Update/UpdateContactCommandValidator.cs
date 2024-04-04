using FluentValidation;

namespace Application.Features.Contacts.Commands.Update;

public class UpdateContactCommandValidator : AbstractValidator<UpdateContactCommand>
{
    public UpdateContactCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Address).NotEmpty();
        RuleFor(c => c.Phone).NotEmpty();
        RuleFor(c => c.Email).NotEmpty();
        RuleFor(c => c.Website).NotEmpty();
        RuleFor(c => c.MapLocation).NotEmpty();
        RuleFor(c => c.Status).NotEmpty();
    }
}