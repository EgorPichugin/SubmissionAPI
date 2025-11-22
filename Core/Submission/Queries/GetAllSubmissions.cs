using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SubmissionAPI.Models.Responses;
using SubmissionAPI.Data;

namespace SubmissionAPI.Core.Submission.Queries;

public record GetAllSubmissionsRequest() : IRequest<IEnumerable<SubmissionResponse>>;

public class GetAllSubmissionsRequestHandler : IRequestHandler<GetAllSubmissionsRequest, IEnumerable<SubmissionResponse>>
{
    public async Task<IEnumerable<SubmissionResponse>> Handle(GetAllSubmissionsRequest request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return MockStorage.Submissions;
    }
}