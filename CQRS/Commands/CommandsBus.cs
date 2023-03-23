using MediatR;

namespace BonProject.CQRS.Commands;

public class CommandsBus : ICommandsBus
{
    private readonly IMediator mediator;

    public CommandsBus(IMediator mediator) => this.mediator = mediator;

    public Task<TResult> ExecuteAsync<TResult>(
        IApplicationCommand<TResult> command,
        CancellationToken cancellationToken = default)
    {
        return this.mediator.Send(command, cancellationToken);
    }

    public Task ExecuteAsync(
        IApplicationCommandWithoutResult command,
        CancellationToken cancellationToken = default)
    {
        return this.mediator.Send(command, cancellationToken);
    }
}