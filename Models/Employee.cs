using System;
using System.ComponentModel.DataAnnotations;

namespace Agrifood.Models;

public class Employee
{
	public int Id { get; set; }

    [StringLength(50, MinimumLength = 3)]
    [Required]
    [Display (Name = "Prénom")]
    public string? FirstName { get; set; }

    [StringLength(50, MinimumLength = 3)]
    [Required]
    [Display(Name = "Nom")]
    public string? LastName { get; set; }

    [Required]
    [Display(Name = "Téléphone fixe")]
    public int LandlinePhone { get; set; }

    [Required]
    [Display(Name = "Téléphone portable")]
    public int MobilePhone { get; set; }

    [Required]
    public string? Email { get; set; }

	public virtual Service? Service { get; set; }

}


