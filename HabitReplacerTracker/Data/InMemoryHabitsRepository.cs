using HabitReplacerTracker.Models;

namespace HabitReplacerTracker.Data;

public class InMemoryHabitsRepository : IHabitsRepository
{
    private readonly Habits _repo = new Habits();

    public Habits GetAllHabits() => _repo;

    public Habit AddHabit(string habitType, string name, string description)
    {
        var habit = new Habit
        {
            Id = Guid.NewGuid().ToString(),
            Name = name,
            Description = description
        };
        if (habitType == "new")
        {
            _repo.NewHabits.Add(habit);

        return GetAllHabits().NewHabits.FirstOrDefault(item => item.Id == habit.Id)!;
        }
        else
        {
            _repo.OldHabits.Add(habit);

        return GetAllHabits().OldHabits.FirstOrDefault(item => item.Id == habit.Id)!;
        }
    }

    public Habits AddHabitActivity(string id, string date, int minutes)
    {
        var activity = new TimeSpent
        {
            Id = Guid.NewGuid().ToString(),
            Date = date,
            Minutes = minutes
        };

        var habit = _repo.NewHabits.FirstOrDefault(habit => habit.Id == id);
        if (habit != null)
        {
            habit.TimeSpent.Add(activity);
        }
        return GetAllHabits();
    }
}