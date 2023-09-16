using MediatR;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Backend.Application.Commands.Candidates.Add;

namespace VotingApp.Backend.Controllers;

public class CandidatesController:BaseController
{
    public CandidatesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpPost]
    public async Task<IActionResult> Post(AddCandidateCommand command)
    {
        await _mediator.Send(command);

        return Ok();
    }
    
}