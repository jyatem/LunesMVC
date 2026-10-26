using System.ComponentModel.DataAnnotations;

namespace HolaMvc.Models;

public class Persona
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Nombre { get; set; } = string.Empty;
}