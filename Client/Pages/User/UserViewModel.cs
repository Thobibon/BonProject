using BonProject.Shared.User;

namespace BonProject.Client.Pages.User;

public record UserViewModel(
    Guid Id,
    string Email,
    string? EmailParainage) : IUser;