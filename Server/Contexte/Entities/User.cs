using BonProject.Shared.User;
using System.ComponentModel.DataAnnotations;

namespace BonProject.Server.Contexte.Entities;

public class UserEntity : IUser
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(128)]
    public string Email { get; set; } = string.Empty;

    public double Chances { get; set; } = 1.0;

    [StringLength(128)]
    public string? EmailParainage { get; set; }
}