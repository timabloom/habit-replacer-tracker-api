using HabitReplacerTracker;

public interface IHabitsRepository
{
    public Habits GetAllHabits();
    public Habits AddHabit();
    public Habits AddHabitActivity();
}