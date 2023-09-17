using VotingApp.Backend.Application.Queries.Candidates.List.DTO;

namespace VotingApp.Backend.Application.Queries.Candidates.List;

public record GetCandidatesQuery: IQuery<List<CandidateDto>>;