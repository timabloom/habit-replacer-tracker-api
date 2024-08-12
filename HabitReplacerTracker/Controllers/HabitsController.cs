using HabitReplacerTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace HabitReplacerTracker.Controllers;

[ApiController]
[Route("[controller]")]
public class HabitsController : ControllerBase
{
    private readonly IHabitsRepository _repo;
    public HabitsController(IHabitsRepository repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public Habits GetHabits() => _repo.GetAllHabits();

    [HttpPost]
    [Route("new")]
    public Habits PostNewHabit(AddHabitRequest habitData)
    {
        var habits = _repo.AddHabit("new", habitData.Id, habitData.Name, habitData.Description, habitData.TimeSpent);
        return habits;
    }

    [HttpPost]
    [Route("old")]
    public Habits PostOldHabit(AddHabitRequest habitData)
    {
        var habits = _repo.AddHabit("old", habitData.Id, habitData.Name, habitData.Description, habitData.TimeSpent);
        return habits;
    }

    [HttpPut("{id}")]
    public Habits PostActivity(string id, AddActivityRequest activityData)
    {
        var habits = _repo.AddHabitActivity(id, activityData.Date, activityData.Minutes);
        return habits;
    }
}
