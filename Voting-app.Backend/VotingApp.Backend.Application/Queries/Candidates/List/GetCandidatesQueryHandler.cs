using Microsoft.EntityFrameworkCore;
using VotingApp.Backend.Application.Queries.Candidates.List.DTO;
using VotingApp.Backend.DataAccess;

namespace VotingApp.Backend.Application.Queries.Candidates.List;

public class GetCandidatesQueryHandler:IQueryHandler<GetCandidatesQuery, List<CandidateDto>>
{
    private readonly Context _context;

    public GetCandidatesQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<List<CandidateDto>> Handle(GetCandidatesQuery request, CancellationToken cancellationToken)
    {
        var candidates = await _context.Candidates.Select(x => new CandidateDto
        {
            Id = x.Id,
            Name = x.Name,
            Votes = x.Votes.Count
        }).ToListAsync(cancellationToken: cancellationToken);

        return candidates;
    }
}