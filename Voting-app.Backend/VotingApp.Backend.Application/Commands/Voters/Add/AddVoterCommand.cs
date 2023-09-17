using MediatR;

namespace VotingApp.Backend.Application.Commands.Voters.Add;

public record AddVoterCommand(string Name) : ICommand<Unit>;
