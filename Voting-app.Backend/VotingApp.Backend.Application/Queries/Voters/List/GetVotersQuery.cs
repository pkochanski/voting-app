using VotingApp.Backend.Application.Queries.Voters.List.DTO;

namespace VotingApp.Backend.Application.Queries.Voters.List;

public record GetVotersQuery : IQuery<List<VoterDto>>;
