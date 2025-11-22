using MediatR;
using Microsoft.AspNetCore.Mvc;
using SubmissionAPI.Core.Submission.Commands;
using SubmissionAPI.Core.Submission.Queries;
using SubmissionAPI.Models.Responses;

namespace SubmissionAPI.Controllers;

[ApiController, Route("api/[controller]")]
public class SubmissionsController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<ActionResult<SubmissionResponse>> Create(
        [FromBody] SubmissionRequest request)
    {
        var result = await mediator.Send(request);
        return Ok(result);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<SubmissionResponse>>> GetAll()
    {
        var result = await mediator.Send(new GetAllSubmissionsRequest());
        return Ok(result);
    }
}