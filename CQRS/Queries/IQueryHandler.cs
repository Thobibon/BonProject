using MediatR;

namespace BonProject.CQRS.Queries;

public interface IQueryHandler
{
}

public interface IQueryHandler<in TQuery, TResult> :
    IQueryHandler,
    IRequestHandler<TQuery, TResult>
    where TQuery : IQuery<TResult>
{
    new Task<TResult> Handle(TQuery query, CancellationToken cancellationToken = default);
}