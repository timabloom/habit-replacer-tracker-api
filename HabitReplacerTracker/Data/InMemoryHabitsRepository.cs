namespace HabitReplacerTracker.Data;

public class InMemoryHabitsRepository : IHabitsRepository
{
    private readonly Habits _repo = new Habits();

    public Habits GetAllHabits() => _repo;

    public Habits AddHabit(string habitType, string id, string name, string description, List<TimeSpent> timeSpent)
    {
        var habit = new Habit
        {
            Id = id,
            Name = name,
            Description = description,
            TimeSpent = timeSpent
        };
        if (habitType == "new")
        {
            _repo.NewHabits.Add(habit);
        }
        else
        {
            _repo.OldHabits.Add(habit);
        }
        return GetAllHabits();
    }

    public Habits AddHabitActivity(string id, string date, int minutes)
    {
        throw new NotImplementedException();
    }
}