using MediatR;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Backend.Application.Commands.Voters.Add;
using VotingApp.Backend.Application.Commands.Voters.Vote;
using VotingApp.Backend.Application.Queries.Voters.List;

namespace VotingApp.Backend.Controllers;

public class VotersController:BaseController
{
    public VotersController(IMediator mediator) : base(mediator)
    {
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetVotersQuery());
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post(AddVoterCommand command)
    {
        await _mediator.Send(command);

        return Ok();
    }

    [HttpPost("vote")]
    public async Task<IActionResult> Vote(VoteCommand command)
    {
        await _mediator.Send(command);
        return Ok();
    }
}