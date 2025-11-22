using System.Text.Json;
using MediatR;
using SubmissionAPI.Models.Responses;
using SubmissionAPI.Data;

namespace SubmissionAPI.Core.Submission.Commands;

public record SubmissionRequest(
    string FormName,
    JsonElement Data) : IRequest<SubmissionResponse>;


public class SubmissionRequestHandler : IRequestHandler<SubmissionRequest, SubmissionResponse>
{
    public async Task<SubmissionResponse> Handle(SubmissionRequest request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.FormName) || string.IsNullOrWhiteSpace(request.Data.ToString()))
        {
            throw new ArgumentException("Invalid submission");
        }
        
        var newSubmission = new SubmissionResponse(
            Guid.NewGuid(),
            request.FormName, 
            DateTime.UtcNow,
            request.Data
        );
        MockStorage.Submissions.Add(newSubmission);
        
        await Task.CompletedTask;
        return newSubmission;
    }
}