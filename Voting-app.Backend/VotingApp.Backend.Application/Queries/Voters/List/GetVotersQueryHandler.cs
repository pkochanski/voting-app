using Microsoft.EntityFrameworkCore;
using VotingApp.Backend.Application.Queries.Voters.List.DTO;
using VotingApp.Backend.DataAccess;

namespace VotingApp.Backend.Application.Queries.Voters.List;

public class GetVotersQueryHandler:IQueryHandler<GetVotersQuery, List<VoterDto>>
{
    private readonly Context _context;

    public GetVotersQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<List<VoterDto>> Handle(GetVotersQuery request, CancellationToken cancellationToken)
    {
        var voters = await _context.Voters.Select(x => new VoterDto
        {
            Id = x.Id,
            Name = x.Name,
            HasVoted = x.VoteId != null
        }). ToListAsync(cancellationToken: cancellationToken);

        return voters;
    }
}