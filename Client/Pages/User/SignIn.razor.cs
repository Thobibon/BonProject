using BonProject.CQRS.Commands;
using Microsoft.AspNetCore.Components;

namespace BonProject.Client.Pages.User;

[Route("/user/sign-in")]
public partial class SignIn
{
    [Inject]
    private ICommandsBus commandsBus { get; set; } = null!;

    private UserViewModel? viewModel;
}