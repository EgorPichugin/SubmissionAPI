using System;
using System.Text.Json;

namespace SubmissionAPI.Models.Responses;

public record SubmissionResponse(
    Guid Id,
    string Title,
    string Type,
    JsonElement Fields
);