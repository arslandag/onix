using CSharpFunctionalExtensions;

namespace Fenix.Domain.ValueObjects;

public record DataSolution
{
    private DataSolution(string question, string answer)
    {
        Question = question;
        Answer = answer;
    }

    public string Question { get; init; }
    public string Answer { get; init; }

    public static Result<DataSolution> Create(string question, string answer)
    {
        return new DataSolution(question, answer);
    }
}