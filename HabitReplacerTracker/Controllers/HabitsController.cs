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
    public Habits PostHabit(AddHabitRequest habitData)
    {
        var habits = _repo.AddHabit(habitData.Id, habitData.Name, habitData.Description, habitData.TimeSpent);
        return habits;
    }
}
