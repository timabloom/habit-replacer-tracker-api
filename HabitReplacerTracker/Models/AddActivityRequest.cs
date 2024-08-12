using System.ComponentModel.DataAnnotations;

namespace HabitReplacerTracker.Models;

public record AddActivityRequest(

    [Required]
    string Id,
    [Required]
    string Date,
    [Required]
    int Minutes
);
