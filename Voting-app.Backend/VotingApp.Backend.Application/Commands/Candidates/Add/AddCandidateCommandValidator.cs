using FluentValidation;

namespace VotingApp.Backend.Application.Commands.Candidates.Add;

public class AddCandidateCommandValidator:AbstractValidator<AddCandidateCommand>
{
    public AddCandidateCommandValidator()
    {
        RuleFor(x => x.Name).NotNull().NotEmpty().WithMessage("Name cannot be empty.");
    }
}