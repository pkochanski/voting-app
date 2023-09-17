using FluentValidation;

namespace VotingApp.Backend.Application.Commands.Voters.Add;

public class AddVoterCommandValidator:AbstractValidator<AddVoterCommand>
{
    public AddVoterCommandValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Name cannot be empty.");
    }
}