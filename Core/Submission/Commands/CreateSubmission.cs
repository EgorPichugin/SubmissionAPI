using System.Text.Json;
using MediatR;
using SubmissionAPI.Models.Responses;
using SubmissionAPI.Data;

namespace SubmissionAPI.Core.Submission.Commands;

public record SubmissionRequest(
    string Type,
    string Title,
    JsonElement Fields) : IRequest<SubmissionResponse>;


public class SubmissionRequestHandler : IRequestHandler<SubmissionRequest, SubmissionResponse>
{
    public async Task<SubmissionResponse> Handle(SubmissionRequest request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Type) || string.IsNullOrWhiteSpace(request.Title) || string.IsNullOrWhiteSpace(request.Fields.ToString()))
        {
            throw new ArgumentException("Invalid submission");
        }
        
        var newSubmission = new SubmissionResponse(
            Guid.NewGuid(),
            request.Title, 
            request.Type,
            request.Fields
        );
        MockStorage.Submissions.Add(newSubmission);
        
        await Task.CompletedTask;
        return newSubmission;
    }
}