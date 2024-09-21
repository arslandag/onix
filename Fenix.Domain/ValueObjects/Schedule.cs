using CSharpFunctionalExtensions;
using DayOfWeek = Fenix.Domain.SharedObjects.DayOfWeek;

namespace Fenix.Domain.ValueObjects;

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
    
    public DayOfWeek DayOfWeek { get; }
    public string StartTime { get; }
    public string EndTime { get; }

    public static Result<Schedule> Create(
        DayOfWeek dayOfWeek,
        string startTime,
        string endTime)
    {
        return new Schedule(dayOfWeek,startTime,endTime);
    }
}