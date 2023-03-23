using MediatR;

namespace BonProject.CQRS.Commands;

public interface IApplicationCommandHandler
{
}

public interface IApplicationCommandHandler<in TCommand, TResult> :
    IApplicationCommandHandler,
    IRequestHandler<TCommand, TResult>
    where TCommand : IApplicationCommand<TResult>
{
    new Task<TResult> Handle(TCommand command, CancellationToken cancellationToken = default);
}
