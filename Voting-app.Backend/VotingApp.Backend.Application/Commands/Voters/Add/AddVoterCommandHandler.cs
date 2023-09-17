using MediatR;
using VotingApp.Backend.DataAccess;
using VotingApp.Backend.DataAccess.Entities;

namespace VotingApp.Backend.Application.Commands.Voters.Add;

public class AddVoterCommandHandler: ICommandHandler<AddVoterCommand, Unit>
{
    private readonly Context _context;

    public AddVoterCommandHandler(Context context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(AddVoterCommand request, CancellationToken cancellationToken)
    {
        var voter = new Voter
        {
            Name = request.Name
        };

        await _context.Voters.AddAsync(voter, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}