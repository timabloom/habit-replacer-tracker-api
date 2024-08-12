using HabitReplacerTracker.Models;

namespace HabitReplacerTracker.Data;

public interface IHabitsRepository
{
    public Habits GetAllHabits();
    public Habit AddHabit(string habitType, string name, string description);
    public Habits AddHabitActivity(string id, string date, int minutes);
}