using MediatR;

namespace BonProject.CQRS.Queries;

public class QueryBus<TQuery, TResult> : IQueryBus<TQuery, TResult>
    where TQuery : IQuery<TResult>
{
    private readonly IMediator mediator;

    public QueryBus(IMediator mediator) => this.mediator = mediator;

    public Task<TResult> GetAsync(TQuery query, CancellationToken cancellationToken = default)
    {
        return this.mediator.Send(query, cancellationToken);
    }
}