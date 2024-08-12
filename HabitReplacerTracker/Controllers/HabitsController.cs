using HabitReplacerTracker.Data;
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
    public ActionResult<Habit> PostNewHabit(AddHabitRequest habitData)
    {
        var habit = _repo.AddHabit("new", habitData.Name, habitData.Description);
        return habit; 
        
    }

    [HttpPost]
    [Route("old")]
    public Habit? PostOldHabit(AddHabitRequest habitData)
    {
        var habits = _repo.AddHabit("old", habitData.Name, habitData.Description);
        return habits;
    }

    [HttpPut("{id}")]
    public Habits PostActivity(string id, AddActivityRequest activityData)
    {
        var habits = _repo.AddHabitActivity(id, activityData.Date, activityData.Minutes);
        return habits;
    }
}
