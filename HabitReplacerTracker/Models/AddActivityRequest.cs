using System.ComponentModel.DataAnnotations;

namespace HabitReplacerTracker.Models;

public record AddActivityRequest(
    [Required]
    [Length(10,10)]
    string Date,
    [Required]
    [Range(1, 1440)]
    int Minutes
);
