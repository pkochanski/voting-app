using MediatR;

namespace VotingApp.Backend.Application.Commands.Voters.Vote;

public record VoteCommand(int VoterId, int CandidateId):ICommand<Unit>;