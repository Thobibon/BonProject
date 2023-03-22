using System.ComponentModel.DataAnnotations;

namespace BonProject.Shared.User;

public interface IUser
{
    public Guid Id { get; }

    [Required]
    [StringLength(128)]
    public string Email { get; }

    public double Chances { get; }

    [StringLength(128)]
    public string? EmailParainage { get; }
}