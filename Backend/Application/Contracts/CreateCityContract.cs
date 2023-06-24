using System.ComponentModel.DataAnnotations;

namespace Backend.Application.Contracts;

public class CreateCityContract
{
    [Required]
    [MinLength(3)]
    public string Name { get; set; } = "";
    [MinLength(2)]
    [MaxLength(2)]
    public string State { get; set; } = "";    
}