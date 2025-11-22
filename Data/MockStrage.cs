
using System.Collections.Generic;
using SubmissionAPI.Models.Responses;

namespace SubmissionAPI.Data;

public static class MockStorage
{
    private static readonly List<SubmissionResponse> _submissions = [];

    public static List<SubmissionResponse> Submissions => _submissions;
}