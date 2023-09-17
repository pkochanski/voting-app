using MediatR;
using Microsoft.EntityFrameworkCore;
using VotingApp.Backend.Application.Exceptions;
using VotingApp.Backend.DataAccess;

namespace VotingApp.Backend.Application.Commands.Voters.Vote;

public class VoteCommandHandler:ICommandHandler<VoteCommand,Unit>
{
    private readonly Context _context;

    public VoteCommandHandler(Context context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(VoteCommand request, CancellationToken cancellationToken)
    {
        var voter = await _context.Voters.Include(x=>x.Vote)
            .FirstOrDefaultAsync(x=>x.Id == request.VoterId, cancellationToken: cancellationToken);
        if (voter is null)
        {
            throw new VoterNotFoundException(request.VoterId);
        }

        var candidate = await _context.Candidates.FindAsync(request.CandidateId);
        if (candidate is null)
        {
            throw new CandidateNotFoundException(request.CandidateId);
        }

        if (voter.VoteId is not null)
        {
            throw new VoterAlreadyVotedException(request.VoterId);
        }

        voter.Vote = new DataAccess.Entities.Vote
        {
            Candidate = candidate
        };

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}