namespace HabitReplacerTracker;

public class Habits
{
    public List<Habit> NewHabits { get; init; } = [];
    public List<Habit> OldHabits { get; init; } = [];
}

public class Habit
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public List<TimeSpent>? TimeSpent { get; set; }
}

public class TimeSpent
{
    public required string Id { get; set; }
    public required string Date { get; set; }
    public required int Minutes { get; set; }
}
