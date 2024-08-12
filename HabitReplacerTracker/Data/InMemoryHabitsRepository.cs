namespace HabitReplacerTracker.Data;

public class InMemoryHabitsRepository : IHabitsRepository
{
    private readonly Habits _repo = new Habits();

    public Habits GetAllHabits() => _repo;

    public Habits AddHabit(string id, string name, string description, List<TimeSpent> timeSpent)
    {
        var habit = new Habit
        {
            Id = id,
            Name = name,
            Description = description,
            TimeSpent = timeSpent
        };
        _repo.NewHabits.Add(habit);
        return _repo;
    }

    public Habits AddHabitActivity(string id, string date, int minutes)
    {
        throw new NotImplementedException();
    }
}