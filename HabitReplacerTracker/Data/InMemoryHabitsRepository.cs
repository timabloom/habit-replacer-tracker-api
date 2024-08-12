using HabitReplacerTracker.Models;

namespace HabitReplacerTracker.Data;

public class InMemoryHabitsRepository : IHabitsRepository
{
    private readonly Habits _repo = new Habits();

    public Habits GetAllHabits() => _repo;

    public Habit AddHabit(string habitType, string name, string? description)
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

    public TimeSpent AddHabitActivity(string id, string date, int minutes)
    {
        var activity = new TimeSpent
        {
            Id = Guid.NewGuid().ToString(),
            Date = date,
            Minutes = minutes
        };

        var newHabit = _repo.NewHabits.FirstOrDefault(habit => habit.Id == id);
        if (newHabit != null)
        {
            newHabit.TimeSpent.Add(activity);
            var timeSpentNewHabit = newHabit.TimeSpent.FirstOrDefault(item => item.Id == activity.Id);
            return timeSpentNewHabit!;
        }
        var oldHabit = _repo.OldHabits.FirstOrDefault(habit => habit.Id == id);
        if (oldHabit != null)
        {
            oldHabit.TimeSpent.Add(activity);
            var timeSpentOldHabit = oldHabit.TimeSpent.FirstOrDefault(item => item.Id == activity.Id);
            return timeSpentOldHabit!;
        }

        throw new KeyNotFoundException($"Habit with {id} not found");
    }
}