using MediatR;
using VotingApp.Backend.DataAccess;
using VotingApp.Backend.DataAccess.Entities;

namespace VotingApp.Backend.Application.Commands.Candidates.Add;

public class AddCandidateCommandHandler:ICommandHandler<AddCandidateCommand,Unit>
{
    private readonly Context _context;

    public AddCandidateCommandHandler(Context context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(AddCandidateCommand request, CancellationToken cancellationToken)
    {
        var candidate = new Candidate
        {
            Name = request.Name
        };

        _context.Candidates.Add(candidate);
        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}