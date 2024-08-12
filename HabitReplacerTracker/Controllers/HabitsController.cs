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
}
