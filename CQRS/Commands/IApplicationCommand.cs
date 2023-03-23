using MediatR;

namespace BonProject.CQRS.Commands;

public interface IApplicationCommand<TResult> :
    IApplicationMessage,
    IRequest<TResult>
{
}

public interface IApplicationCommandWithoutResult :
    IApplicationMessage,
    IRequest
{
}
