using MediatR;
using Microsoft.AspNetCore.Mvc;
using VotingApp.Backend.Application.Commands.Candidates.Add;
using VotingApp.Backend.Application.Queries.Candidates.List;

namespace VotingApp.Backend.Controllers;

public class CandidatesController:BaseController
{
    public CandidatesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var result = await _mediator.Send(new GetCandidatesQuery());
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post(AddCandidateCommand command)
    {
        await _mediator.Send(command);

        return Ok();
    }
    
}