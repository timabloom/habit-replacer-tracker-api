using HabitReplacerTracker;

public interface IHabitsRepository
{
    public Habits GetAllHabits();
    public Habits AddHabit(string habitType, string name, string description);
    public Habits AddHabitActivity(string id, string date, int minutes);
}