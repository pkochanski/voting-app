using MediatR;

namespace VotingApp.Backend.Controllers;

public class VotersController:BaseController
{
    public VotersController(IMediator mediator) : base(mediator)
    {
    }
}