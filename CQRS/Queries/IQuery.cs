using MediatR;

namespace BonProject.CQRS.Queries;

public interface IQuery
{
}

public interface IQuery<TResult> : IRequest<TResult>, IQuery
{
}
