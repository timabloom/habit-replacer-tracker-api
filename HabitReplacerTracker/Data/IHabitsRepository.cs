using HabitReplacerTracker;

public interface IHabitsRepository
{
    public Habits GetAllHabits();
    public Habits AddHabit(string habitType, string id, string name, string description, List<TimeSpent> timeSpent);
    public Habits AddHabitActivity(string id, string date, int minutes);
}