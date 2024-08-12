namespace HabitReplacerTracker.Data;

public class InMemoryHabitsRepository : IHabitsRepository
{
    private readonly Habits _repo = new Habits();

    public Habits GetAllHabits() => _repo;

    public Habits AddHabit()
    {
        throw new NotImplementedException();
    }

    public Habits AddHabitActivity()
    {
        throw new NotImplementedException();
    }
}