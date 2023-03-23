using MediatR;

namespace BonProject.CQRS.Queries;

public interface IQueryBus<in TQuery, TResult>
    where TQuery : IQuery<TResult>
{
    Task<TResult> GetAsync(TQuery query, CancellationToken cancellationToken = default);
}