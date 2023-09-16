using MediatR;

namespace VotingApp.Backend.Application.Commands.Candidates.Add;

public record AddCandidateCommand(string Name):ICommand<Unit>;