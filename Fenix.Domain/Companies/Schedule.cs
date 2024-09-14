using CSharpFunctionalExtensions;

namespace Fenix.Domain.Companies;

public record Schedule
{
    private Schedule(
        DayOfWeek dayOfWeek,
        string startTime,
        string endTime)
    {
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;
    }
    
    public DayOfWeek DayOfWeek { get; init; }
    public string StartTime { get; init; }
    public string EndTime { get; init; }

    public static Result<Schedule> Create(
        DayOfWeek dayOfWeek,
        string startTime,
        string endTime)
    {
        return new Schedule(dayOfWeek,startTime,endTime);
    }
}