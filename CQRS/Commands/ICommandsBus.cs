namespace BonProject.CQRS.Commands;

public interface ICommandsBus
{
    Task<TResult> ExecuteAsync<TResult>(IApplicationCommand<TResult> command, CancellationToken cancellationToken = default);
    Task ExecuteAsync(IApplicationCommandWithoutResult command, CancellationToken cancellationToken = default);
}