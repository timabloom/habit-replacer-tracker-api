namespace HabitReplacerTracker.Models;

public class Habits
{
    public List<Habit> NewHabits { get; set; } = [];
    public List<Habit> OldHabits { get; set; } = [];
}

public class Habit
{
    public required string Id { get; init; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public List<TimeSpent> TimeSpent { get; set; } = [];
}

public class TimeSpent
{
    public required string Id { get; init; }
    public required string Date { get; init; }
    public required int Minutes { get; init; }
}
