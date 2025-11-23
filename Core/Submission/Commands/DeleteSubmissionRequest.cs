using MediatR;
using SubmissionAPI.Data;

namespace SubmissionAPI.Core.Submission.Commands;

public record DeleteSubmissionRequest(Guid Id) : IRequest<Unit>;

public class DeleteSubmissionRequestHandler : IRequestHandler<DeleteSubmissionRequest, Unit>
{
    public async Task<Unit> Handle(DeleteSubmissionRequest request, CancellationToken cancellationToken)
    {
        MockStorage.Submissions.RemoveAll(submission => submission.Id == request.Id);
        
        await Task.CompletedTask;
        return Unit.Value;
    }
}