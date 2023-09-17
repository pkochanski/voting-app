using FluentValidation;

namespace VotingApp.Backend.Application.Commands.Voters.Vote;

public class VoteCommandValidator:AbstractValidator<VoteCommand>
{
    public VoteCommandValidator()
    {
        RuleFor(x => x.VoterId).NotNull().NotEmpty().WithMessage("Choose voter.");
        RuleFor(x => x.CandidateId).NotNull().NotEmpty().WithMessage("Choose candidate.");
    }
}