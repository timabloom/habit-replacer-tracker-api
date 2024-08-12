using System.ComponentModel.DataAnnotations;

namespace HabitReplacerTracker.Models;

public record AddHabitRequest(

    [Required]
    string Id,
    [Required]
    string Name,
    string? Description,
    List<TimeSpent>? TimeSpent
);



