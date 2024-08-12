using System.ComponentModel.DataAnnotations;

namespace HabitReplacerTracker.Models;

public record AddHabitRequest(
    [Required]
    string Name,
    string? Description
);



