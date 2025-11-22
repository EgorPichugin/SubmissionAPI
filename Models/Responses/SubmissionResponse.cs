using System;
using System.Text.Json;

namespace SubmissionAPI.Models.Responses;

public record SubmissionResponse(
    Guid Id,
    string FormName,
    DateTime CreatedAt,
    JsonElement Data
);